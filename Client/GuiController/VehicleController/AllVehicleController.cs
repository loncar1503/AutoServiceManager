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

namespace Client.GuiController.VehicleController
{
    internal class AllVehicleController
    {
        private UCAllVehicles forma;
        private List<Vozilo> allVehicles;

        public AllVehicleController(UCAllVehicles forma)
        {
            this.forma = forma;
            Init();
        }

        internal void Search()
        {

            try
            {
                var q = string.IsNullOrWhiteSpace(forma.txtFilter.Text)
                        ? null
                        : forma.txtFilter.Text.Trim();

                var filter = new VehicleFilter { Query = q };

                var filtered = Communication.Instance
                    .PosaljiZahtevVratiRezultat<List<Vozilo>>(Operation.SearchVehicles, filter);

                // Rebind bez dupliranja kolona:
                var hadCols = forma.dgvAllVehicles.Columns.Count > 0;
                forma.dgvAllVehicles.DataSource = null;
                if (!hadCols) SetupDGV(); // kolone kreiraj samo prvi put
                forma.dgvAllVehicles.DataSource = filtered;
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
        internal void EditForm()
        {
            if (forma.dgvAllVehicles.SelectedRows.Count > 0)
            {
                Vozilo v = Communication.Instance.PosaljiZahtevVratiRezultat<Vozilo>(Common.Communication.Operation.GetVehicle,
                    forma.dgvAllVehicles.SelectedRows[0].DataBoundItem as Vozilo);
                FrmEditVehicle frmEdit = new FrmEditVehicle(v);

                frmEdit.ShowDialog();

                forma.dgvAllVehicles.Columns.Clear();

                SetupDGV();
            }
            else
            {
                MessageBox.Show("Please choose the vehicle that you want to edit");
            }
        }
        internal void DeleteVehicle()
        {
            
            try
            {
                DialogResult result = MessageBox.Show("Are you sure that you want to delete this vehicle?", "Deleting confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Vozilo v = forma.dgvAllVehicles.SelectedRows[0].DataBoundItem as Vozilo;
                    Communication.Instance.PosaljiZahtevBezRezultata(Common.Communication.Operation.DeleteVehicle, v);
                }
                forma.dgvAllVehicles.Columns.Clear();

                SetupDGV();
                MessageBox.Show("Vehicle successfully deleted", "Vehicle deleted! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

            }
            catch (ServerCommunicationException e)
            {
                MessageBox.Show("Sistem ne moze da zapamti vozilo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.Message);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception es)
            {
                MessageBox.Show("Sistem ne moze da zapamti vozilo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(es.Message);
            }
        }

        private void Init()
        {
            try
            {
                forma.dgvAllVehicles.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
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
                
                allVehicles = Communication.Instance.PosaljiZahtevVratiRezultat<List<Vozilo>>(Common.Communication.Operation.GetAllVehicles);
                forma.dgvAllVehicles.AutoGenerateColumns = false;
                forma.dgvAllVehicles.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colReg",
                    DataPropertyName = "RegBroj",
                    HeaderText = "Registracija"
                });
                forma.dgvAllVehicles.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colYear",
                    DataPropertyName = "GodinaProizvodnje",
                    HeaderText = "Godina"
                });

                // „unbound“ kolone za ugnježđene podatke (samo prikaz)
                forma.dgvAllVehicles.Columns.Add(new DataGridViewTextBoxColumn { Name = "colBrand", HeaderText = "Marka", ReadOnly = true });
                forma.dgvAllVehicles.Columns.Add(new DataGridViewTextBoxColumn { Name = "colModel", HeaderText = "Model", ReadOnly = true });
                forma.dgvAllVehicles.Columns.Add(new DataGridViewTextBoxColumn { Name = "colOwner", HeaderText = "Vlasnik", ReadOnly = true });
                forma.dgvAllVehicles.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPhone", HeaderText = "Telefon", ReadOnly = true });
                forma.dgvAllVehicles.CellFormatting += DgvAllVehicles_CellFormatting;

                forma.dgvAllVehicles.DataSource = allVehicles;


                //forma.dgvAllVehicles.DataSource = allVehicles.Select(v => new
                //{
                //    Registration = v.RegBroj,
                //    Brand = v.ModelVozila.Marka,
                //    Model = v.ModelVozila,
                //    Year = v.GodinaProizvodnje,
                //    Owner = v.Klijent
                //}).ToList();

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
        private void DgvAllVehicles_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (sender is not DataGridView dgv) return;

            var rowItem = dgv.Rows[e.RowIndex].DataBoundItem as Vozilo;
            if (rowItem is null) return;

            switch (dgv.Columns[e.ColumnIndex].Name)
            {
                case "colBrand":
                    e.Value = rowItem.ModelVozila?.Marka?.Naziv;
                    e.FormattingApplied = true;
                    break;

                case "colModel":
                    e.Value = rowItem.ModelVozila?.Naziv;
                    e.FormattingApplied = true;
                    break;

                case "colOwner":
                    var ime = rowItem.Klijent?.Ime ?? "";
                    var prezime = rowItem.Klijent?.Prezime ?? "";
                    e.Value = $"{ime} {prezime}".Trim();
                    e.FormattingApplied = true;
                    break;

                case "colPhone":
                    e.Value = rowItem.Klijent?.BrojTelefona;
                    e.FormattingApplied = true;
                    break;
            }
        }

        
    }
}
