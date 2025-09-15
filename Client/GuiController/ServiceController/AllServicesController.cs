using Client.UserControls;
using Common.Communication;
using Common.Domain;
using Common.Domain.DTO;
using Client.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.GuiController.ServiceController
{
    internal class AllServicesController
    {
        UCAllServices forma;
        public List<Servis> allServices;
        public AllServicesController(UCAllServices forma)
        {
            this.forma = forma;
            Init();
        }

        internal void CheckedChanged()
        {
            if (forma.chckAny.Checked == true)
            {
                forma.dtpDateFrom.Enabled = false;
                forma.dtpDateTo.Enabled = false;
            }
            else
            {
                forma.dtpDateFrom.Enabled = true;
                forma.dtpDateTo.Enabled = true;
            }
        }

        internal void SearchServices()
        {
            try
            {
                var filter = new ServisFilter
                {
                    Query = string.IsNullOrWhiteSpace(forma.txtCondition.Text)
                            ? null
                            : forma.txtCondition.Text.Trim()
                };

                // Ako NIJE čekiran "Any", koristi opseg datuma
                if (!forma.chckAny.Checked)
                {
                    var d1 = forma.dtpDateFrom.Value.Date;
                    var d2 = forma.dtpDateTo.Value.Date;


                    filter.DateFrom = d1;
                    filter.DateTo = d2;
                }

                List<Servis> filtered = Communication.Instance
                    .PosaljiZahtevVratiRezultat<List<Servis>>(Operation.SearchServices, filter);

                // Rebind bez ponovnog pravljenja kolona:
                forma.dgvAllServices.DataSource = null;
                forma.dgvAllServices.DataSource = filtered;
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        internal void EditService()
        {
            if (forma.dgvAllServices.SelectedRows.Count > 0) {
                Servis servis = Communication.Instance.PosaljiZahtevVratiRezultat<Servis>(Common.Communication.Operation.GetService,
                    forma.dgvAllServices.SelectedRows[0].DataBoundItem as Servis);
                FrmEditService frmEdit = new FrmEditService(servis);
                frmEdit.ShowDialog();

                forma.dgvAllServices.Columns.Clear();
                SetupDGV();
            }
            else
            {
                MessageBox.Show("Please choose the service that you want to edit");
            }
        }
        private void Init()
        {
            try
            {
                forma.txtCondition.Text = "";
                forma.chckAny.Checked = true;

            
                forma.dtpDateFrom.Enabled = false;
                forma.dtpDateTo.Enabled = false;
                forma.dgvAllServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SetupDGV();

            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }


        }

        private void SetupDGV()
        {
            try
            {
                
                allServices = Communication.Instance.PosaljiZahtevVratiRezultat<List<Servis>>(Common.Communication.Operation.GetAllServices);
                forma.dgvAllServices.AutoGenerateColumns = false;
                forma.dgvAllServices.Columns.Add(new DataGridViewTextBoxColumn { Name = "colReg", HeaderText = "Registration number", ReadOnly = true });
                forma.dgvAllServices.Columns.Add(new DataGridViewTextBoxColumn { Name = "colBrandModel", HeaderText = "Brand (Model)", ReadOnly = true });
                forma.dgvAllServices.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMechanic", HeaderText = "Mechanic", ReadOnly = true });
                forma.dgvAllServices.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colDate",
                    DataPropertyName = "DatumPrijema",
                    HeaderText = "Date of service"
                });
                forma.dgvAllServices.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colPrice",
                    DataPropertyName = "UkupnaCena",
                    HeaderText = "Total price"
                });
                forma.dgvAllServices.Columns.Add(new DataGridViewTextBoxColumn 
                {
                    Name = "colDesc",
                    DataPropertyName = "OpisProblema",
                    HeaderText = "Description"
                });
                forma.dgvAllServices.Columns["colDate"].DefaultCellStyle.Format = "dd.MM.yyyy";



                forma.dgvAllServices.CellFormatting += DgvAllServices_CellFormatting;

                forma.dgvAllServices.DataSource = allServices;


              
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        private void DgvAllServices_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (sender is not DataGridView dgv) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // ključna zaštita – proveri izvor podataka (lista) pre pristupa Rows
            if (dgv.DataSource is System.Collections.IList list && e.RowIndex >= list.Count) return;
            if (e.RowIndex >= dgv.Rows.Count) return;

            var row = dgv.Rows[e.RowIndex];
            if (row.IsNewRow) return;
            if (row.DataBoundItem is not Servis rowItem) return;

            switch (dgv.Columns[e.ColumnIndex].Name)
            {
                case "colReg":
                    e.Value = rowItem.Vozilo?.RegBroj;
                    e.FormattingApplied = true;
                    break;

                case "colBrandModel":
                    e.Value = rowItem.Vozilo?.ModelVozila.Naziv + " ("+rowItem.Vozilo?.ModelVozila?.Marka?.Naziv+")";
                    e.FormattingApplied = true;
                    break;

                case "colMechanic":
                    var ime = rowItem.Majstor?.Ime ?? "";
                    var prezime = rowItem.Majstor?.Prezime ?? "";
                    e.Value = $"{ime} {prezime}".Trim();
                    e.FormattingApplied = true;
                    break;

                
            }
        }

        
    }
}
