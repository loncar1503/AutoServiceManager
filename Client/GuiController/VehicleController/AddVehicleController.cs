using Client.Exceptions;
using Client.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Client.GuiController.VehicleController
{
    internal class AddVehicleController
    {
        private UCAddVehicle forma;
        Klijent owner;
        public AddVehicleController(UCAddVehicle forma)
        {
            this.forma = forma;
            Init();
            owner=new Klijent();
        }

        public void FillCMBModel(Marka marka)
        {
            forma.cmbModel.Enabled= true;
            forma.cmbModel.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<ModelVozila>>(Common.Communication.Operation.GetAllModels).Where(x=>x.MarkaId==marka.Id).ToList();

            forma.cmbModel.SelectedIndex = -1;
        }

        internal void AddOwner()
        {
           
            try
            {
                owner.Ime = forma.txtIme.Text;
                owner.Prezime = forma.txtPrezime.Text;
                owner.BrojTelefona = forma.txtBrTel.Text;
                owner.Id = ((Klijent)Communication.Instance.PosaljiZahtevVratiRezultat<Klijent>(Common.Communication.Operation.AddOwner, owner)).Id;
                MessageBox.Show("Owner successfully added", "Owner aded! ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne moze da zapamti vlasnika.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OcistiFormu();
            }
            catch (Exception es)
            {
                MessageBox.Show("Sistem ne moze da zapamti vlasnika.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void AddVehicle()
        {
            if (!ValidirajPodatke()){
                return;
            }
            if(forma.panel1.Visible==false)
            {
                owner.Id = ((Klijent)forma.cmbOwners.SelectedItem).Id;
            }
            Vozilo v = new Vozilo
            {
                RegBroj = forma.txtRegBroj.Text,
                GodinaProizvodnje = int.Parse(forma.txtGodinaProizv.Text),
                ModelVozilaId = ((ModelVozila)forma.cmbModel.SelectedValue).Id,
                
                KlijentId =owner.Id
                //Klijent = new Common.Domain.Klijent
                //{

                //    //Ime = forma.txtIme.Text,
                //    //Prezime = forma.txtPrezime.Text,
                //    //BrojTelefona = forma.txtBrTel.Text
                //}
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Common.Communication.Operation.AddVehicle, v);

                MessageBox.Show("Vehicle successfully saved", "Vehicle aded! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiFormu();

            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("System cannot save the vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OcistiFormu();
            }
            catch (Exception es)
            {
                MessageBox.Show("System cannot save the vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void chooseFromPreviousSelected()
        {
            forma.btnCreateNewOwner.StateCommon.Content.ShortText.Color1 = Color.Orange;
            forma.btnChooseOwner.StateCommon.Content.ShortText.Color1 = Color.White;
            forma.panel1.Visible = false;
            forma.btnDodajVlasnika.Visible = false;
            forma.cmbOwners.Visible = true;

        }

        internal void createNewSelected()
        {
            forma.btnCreateNewOwner.StateCommon.Content.ShortText.Color1 = Color.White;
            forma.btnChooseOwner.StateCommon.Content.ShortText.Color1 = Color.Orange;
            forma.panel1.Visible = true;
            forma.btnDodajVlasnika.Visible = true;
            forma.cmbOwners.Visible = false;

        }

        private void Init()
        {
            try
            {
                forma.cmbMarka.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Marka>>(Common.Communication.Operation.GetAllBrands);
                
                forma.cmbMarka.SelectedIndex = -1;

                forma.cmbModel.Enabled = false;
                forma.txtBrTel.Text = "+381";

                forma.btnCreateNewOwner.StateCommon.Content.ShortText.Color1 = Color.White;
                forma.cmbOwners.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Klijent>>(Common.Communication.Operation.GetAllOwners);
                forma.cmbOwners.Visible = false;
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


        private void OcistiFormu()
        {
            forma.txtIme.Text = "";
            forma.txtRegBroj.Text = "";
            forma.txtPrezime.Text = "";
            forma.txtGodinaProizv.Text = "";
            forma.txtBrTel.Text = "+381";
            forma.cmbMarka.SelectedIndex = -1;
            forma.cmbModel.SelectedIndex = -1;
        }
        private bool ValidirajPodatke()
        {
            if (forma.cmbMarka.SelectedItem == null)
            {
                MessageBox.Show("Molimo vas izaberite marku.");
                return false;
            }
            if(forma.cmbModel.SelectedItem == null)
            {
                MessageBox.Show("Molimo vas odaberite model.");
                return false;
            }
            if (forma.panel1.Visible && string.IsNullOrWhiteSpace(forma.txtIme.Text))
            {
                MessageBox.Show("Polje za ime ne sme biti prazno.");
                return false;
            }
            if (forma.panel1.Visible && string.IsNullOrWhiteSpace(forma.txtPrezime.Text))
            {
                MessageBox.Show("Polje za prezime ne sme biti prazno.");
                return false;
            }
            if (forma.panel1.Visible && string.IsNullOrWhiteSpace(forma.txtBrTel.Text))
            {
                MessageBox.Show("Polje za broj telefona ne sme biti prazno.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(forma.txtGodinaProizv.Text))
            {
                MessageBox.Show("Polje za godinu proizvodnje ne sme biti prazno.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(forma.txtRegBroj.Text))
            {
                MessageBox.Show("Polje za registraciju ne sme biti prazno.");
                return false;
            }
            if (forma.panel1.Visible && !forma.txtBrTel.Text.StartsWith("+381"))
            {
                MessageBox.Show("Polje za broj telefona mora zapocinjati sa +381");
                return false;
            }
            if (forma.panel1.Visible && !System.Text.RegularExpressions.Regex.IsMatch(forma.txtIme.Text, @"^[A-ZŠĐČĆŽ][a-zšđčćž]+$"))
            {
                MessageBox.Show("Ime može sadržavati samo slova i mora poceti velikim slovom.");
                return false;
            }

            

            if (forma.panel1.Visible && !System.Text.RegularExpressions.Regex.IsMatch(forma.txtPrezime.Text, @"^[A-ZŠĐČĆŽ][a-zšđčćž]+$"))
            {
                MessageBox.Show("Prezime može sadržavati samo slova i mora poceti velikim slovom.");
                return false;
            }

            

            return true;
        }
    }
}
