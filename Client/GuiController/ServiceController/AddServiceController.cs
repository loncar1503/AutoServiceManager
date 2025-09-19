using Client.UserControls;
using Common.Domain;
using Client.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.GuiController.ServiceController
{
    internal class AddServiceController
    {
        UCAddService forma;
        private BindingList<StavkaServisa> serviceItems;
        public AddServiceController(UCAddService forma)
        {
            serviceItems= new BindingList<StavkaServisa> ();
            this.forma = forma;
            Init();
        }

        private void Init()
        {
           
            try
            {
                forma.txtDescription.AutoSize = false;                 
                forma.txtDescription.Size = new Size(308, 132);        
                forma.txtDescription.StateCommon.Content.Padding = new Padding(8, 10, 8, 10); 

                forma.txtNote.AutoSize = false;                
                forma.txtNote.Size = new Size(308, 132);         
                forma.txtNote.StateCommon.Content.Padding = new Padding(8, 10, 8, 10); 

                forma.txtUkupnaCena.Enabled = false;

                //Popunjavanj cmba
                forma.cmbVozilo.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Vozilo>>(Common.Communication.Operation.GetAllVehicles);
                forma.cmbMehanicar.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Majstor>>(Common.Communication.Operation.GetAllMechanics);
                forma.cmbUsluga.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Usluga>>(Common.Communication.Operation.GetAllJobs);
                forma.cmbMehanicar.SelectedIndex = -1;
                forma.cmbUsluga.SelectedIndex = -1;
                forma.cmbVozilo.SelectedIndex = -1;
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
        public void AddService()
        {
            forma.cmbUsluga.StateCommon.ComboBox.Back.Color1 = Color.WhiteSmoke;
            forma.cmbVozilo.StateCommon.ComboBox.Back.Color1 = Color.WhiteSmoke;
            forma.cmbMehanicar.StateCommon.ComboBox.Back.Color1 = Color.WhiteSmoke;

            if (!ValidirajPodatke())
            {
                MessageBox.Show("You need to fill all required fields!");

                return;
            }
            Majstor m = (Majstor)forma.cmbMehanicar.SelectedItem;
            Vozilo v = (Vozilo)forma.cmbVozilo.SelectedItem;
            Servis s = new Servis
            {
                OpisProblema = forma.txtDescription.Text,
                DatumPrijema = forma.dtpDatum.Value,
                UkupnaCena = Int32.Parse(forma.txtUkupnaCena.Text.Split()[0]),
                MajstorId = m.Id,
                VoziloRegBroj = v.RegBroj,
                Stavke = serviceItems.Select((st, i) => new StavkaServisa
                {
                    Rb = i + 1,                 
                    UslugaId = st.UslugaId,           
                    Cena = st.Cena,
                    Napomena = st.Napomena
                }).ToList()
            };
            serviceItems.Clear();

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Common.Communication.Operation.AddService, s);

                MessageBox.Show("Service successfully saved", "Service aded! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiFormu();

            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("System cannot save the service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OcistiFormu();
            }
            catch (Exception es)
            {
                MessageBox.Show("System cannot save the service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void AddServiceItem()
        {

            try
            {
                Usluga job = (Usluga)forma.cmbUsluga.SelectedItem;
                if (job == null)
                {
                    MessageBox.Show("Please select job that you want to add to the service!"); ;
                    return;
                }
                StavkaServisa sI = new StavkaServisa()
                {
                    Rb = serviceItems.Count() + 1,
                    Cena = job.Cena,
                    Napomena = forma.txtNote.Text,
                    UslugaId = job.Id,
                    Usluga = job
                };
                serviceItems.Add(sI);

                forma.txtNote.Text = "";
                forma.cmbUsluga.SelectedIndex = -1;
                if (forma.txtUkupnaCena.Text == "")
                {
                    forma.txtUkupnaCena.Text = sI.Cena + " RSD";
                }
                else
                {

                    forma.txtUkupnaCena.Text = (Int32.Parse(forma.txtUkupnaCena.Text.Split()[0]) + sI.Cena).ToString() + " RSD";
                }
                forma.cmbUsluga.SelectedIndex = -1;
                forma.txtNote.Text = "";
            }
            catch (NullReferenceException ex)
            {

                MessageBox.Show("You need to choose job that you want to add to the service!");;
            }
        }

        internal void DeleteServiceItem()
        {
            try
            {

                var row = forma.dgvUsluge.SelectedRows[0];
                if (row?.DataBoundItem is StavkaServisa s)
                {
                    serviceItems.Remove(s);

                    forma.txtUkupnaCena.Text = (Int32.Parse(forma.txtUkupnaCena.Text.Split()[0]) - s.Cena).ToString() + " RSD";

                    for (int i = 0; i < serviceItems.Count; i++)
                        serviceItems[i].Rb = i + 1;
                }

                forma.cmbUsluga.SelectedIndex = -1;
                forma.txtNote.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please sellect service item that you want to delete");
            }
        }
        private void SetupDGV()
        {
            try
            {
                forma.dgvUsluge.AllowUserToAddRows = false;
                forma.dgvUsluge.AutoGenerateColumns = false;
                forma.dgvUsluge.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                forma.dgvUsluge.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                forma.dgvUsluge.Columns.Add(new DataGridViewTextBoxColumn { Name = "colJobName", HeaderText = "Job name", ReadOnly = true });
                forma.dgvUsluge.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colPrice",
                    DataPropertyName = "Cena",
                    HeaderText = "Price"
                }); 
                forma.dgvUsluge.Columns.Add(new DataGridViewTextBoxColumn { Name = "colJobDescription", HeaderText = "Description", ReadOnly = true });
                forma.dgvUsluge.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colNote",
                    DataPropertyName = "Napomena",
                    HeaderText = "Note"
                });

                forma.dgvUsluge.CellFormatting += DgvUsluge_CellFormatting;
                forma.dgvUsluge.DataSource = serviceItems;

                forma.dgvUsluge.Columns["colJobDescription"].Width = 200;
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

        private void DgvUsluge_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {



            if (sender is not DataGridView dgv) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            
            if (dgv.DataSource is System.Collections.IList list && e.RowIndex >= list.Count) return;

            
            if (e.RowIndex >= dgv.Rows.Count) return;

            var row = dgv.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            if (row.DataBoundItem is not StavkaServisa rowItem) return;

            switch (dgv.Columns[e.ColumnIndex].Name)
            {
                case "colJobName":
                    e.Value = rowItem.Usluga?.Naziv;
                    e.FormattingApplied = true;
                    break;
                case "colJobDescription":
                    e.Value = rowItem.Usluga?.Opis;
                    e.FormattingApplied = true;
                    break;
            }
            #region Starapodesavanja
            //if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            //if (sender is not DataGridView dgv) return;

            //// ključna zaštita: uporedi sa brojem elemenata u listi
            //if (dgv.DataSource is System.Collections.IList list)
            //{
            //    if (e.RowIndex >= list.Count) return;
            //}
            //else
            //{
            //    // ako nije IList, zadrži postojeću zaštitu na Rows.Count
            //    if (e.RowIndex >= dgv.Rows.Count) return;
            //}

            //if (dgv == null) return;

            //// zaštite od “nepostojećih” redova/kolona tokom repaint‑a
            //if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            //if (e.RowIndex >= dgv.Rows.Count) return;

            //var row = dgv.Rows[e.RowIndex];
            //if (row.IsNewRow) return;                       

            //if (row.DataBoundItem is not StavkaServisa rowItem) return;

            //switch (dgv.Columns[e.ColumnIndex].Name)
            //{
            //    case "colJobName":
            //        e.Value = rowItem.Usluga?.Naziv;
            //        e.FormattingApplied = true;
            //        break;
            //    case "colJobDescription":
            //        e.Value = rowItem.Usluga?.Opis;
            //        e.FormattingApplied = true;
            //        break;
            //}

            /////////////
            //if (sender is not DataGridView dgv) return;
            //var rowItem = dgv.Rows[e.RowIndex].DataBoundItem as StavkaServisa;
            //if (rowItem is null) return;

            //switch (dgv.Columns[e.ColumnIndex].Name)
            //{
            //    case "colJobName":
            //        e.Value = rowItem.Usluga?.Naziv;
            //        e.FormattingApplied = true;
            //        break;

            //    case "colJobDescription":
            //        e.Value = rowItem.Usluga?.Opis;
            //        e.FormattingApplied = true;
            //        break;

            //}
            #endregion
        }



        private void OcistiFormu()
        {
            forma.cmbMehanicar.SelectedIndex = -1;
            forma.cmbUsluga.SelectedIndex = -1;
            forma.cmbVozilo.SelectedIndex = -1;
            forma.txtDescription.Text = "";
            forma.txtUkupnaCena.Text = "";
            forma.txtNote.Text = "";
        }
        private bool ValidirajPodatke()
        {
            bool valid = true;

            if (forma.cmbMehanicar.SelectedItem == null)
            {
                forma.cmbMehanicar.StateCommon.ComboBox.Back.Color1 = Color.Salmon;

                valid = false;
            }
            if (forma.cmbVozilo.SelectedItem == null)
            {
                forma.cmbVozilo.StateCommon.ComboBox.Back.Color1 = Color.Salmon;
                valid = false;
            }
            if (serviceItems.Count() == 0)
            {
                forma.cmbUsluga.StateCommon.ComboBox.Back.Color1 = Color.Salmon;
                valid = false;
            }



            return valid;
        }

        
    }
}
