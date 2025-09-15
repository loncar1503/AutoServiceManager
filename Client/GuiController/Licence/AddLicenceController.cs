using Client.Exceptions;
using Client.UserControls;
using Common.Domain;
using Client.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.GuiController.Licence
{

    internal class AddLicenceController
    {
        UCAddLicence forma;

        public AddLicenceController(UCAddLicence forma)
        {
            this.forma = forma;
            Init();
        }

        internal void SaveLicence()
        {
            if (!ValidirajPodatke())
            {
                return;
            }
            Licenca l= new Licenca()
            {
                Institucija = forma.cmbInstitution.SelectedValue.ToString(),
                Kategorija = forma.cmbCategory.SelectedValue.ToString(),
                Naziv = forma.txtName.Text
            };
            MajstorLicenca ml = new MajstorLicenca()
            {
               MajstorId=forma.majstor.Id,
               Licenca = l,
            };
            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Common.Communication.Operation.AddLicence, ml);
                OcistiFormu();
                MessageBox.Show("Licence successfully saved", "Licence aded! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiFormu();

            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne moze da zapamti licencu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OcistiFormu();
            }
            catch (Exception es)
            {
                MessageBox.Show("Sistem ne moze da zapamti licencu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Init()
        {
            
            forma.cmbInstitution.DataSource = new List<string>() { "Bosch Training Center", "AMSS Training Center", "Faculty of Engineering", "Ministry of Transport", "SGS Academy" };
            forma.cmbCategory.DataSource = new List<string>() { "Electronics", "HVAC & Refrigeration Systems", "Mechanics", "E-Mobility", "Technical Inspection", "Quality Standards" };
            forma.cmbCategory.SelectedIndex = -1;
            forma.cmbInstitution.SelectedIndex = -1;
        }


        private void OcistiFormu()
        {
            forma.cmbCategory.SelectedIndex = -1;
            forma.cmbInstitution.SelectedIndex= -1;
            forma.txtName.Text = "";
        }

        private bool ValidirajPodatke()
        {
            if (forma.txtName.Text == "")
            {
                MessageBox.Show("Please type the name of the licence.");
                return false;
            }
            if (forma.cmbInstitution.SelectedItem == null)
            {
                MessageBox.Show("Please select the Institution.");
                return false;
            }
            if (forma.cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select the category.");
                return false;
            }




            return true;
        }
    }
}
