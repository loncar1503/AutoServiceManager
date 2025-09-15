using Client.GuiController.VehicleController;
using Common.Domain;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmEditVehicle : KryptonForm
    {
        Vozilo vehicle;
        EditVehicleController controller;
        public FrmEditVehicle(Vozilo vehicle)
        {
            this.vehicle = vehicle;
            InitializeComponent();
            controller = new EditVehicleController(this, vehicle);
            FrmLoad();
        }

        private void FrmLoad()
        {
            kryptonPalette1.ButtonSpecs.FormRestore.Image = Image.FromFile("Images/maximize.png");
            kryptonPalette1.ButtonSpecs.FormMax.Image = Image.FromFile("Images/maximize.png");
            kryptonPalette1.ButtonSpecs.FormMin.Image = Image.FromFile("Images/minimize.png");
            kryptonPalette1.ButtonSpecs.FormClose.Image = Image.FromFile("Images/exit.png");
           


        }
        private void cmbMarka_SelectedValueChanged(object sender, EventArgs e)
        {
            if (controller == null)
            {
                controller = new EditVehicleController(this, vehicle);
            }
            if (cmbMarka.SelectedItem != null)
            {

                controller.FillCMBModel((Marka)cmbMarka.SelectedItem);
            }
        }


        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Save these changes?", "Changes confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                controller.SaveChanges();
                this.Close();
            }

        }

        private void btnChooseOwner_Click(object sender, EventArgs e)
        {
            controller.chooseFromPreviousSelected();
        }

        private void btnCreateNewOwner_Click(object sender, EventArgs e)
        {
            controller.createNewSelected();
        }

        private void btnDodajVlasnika_Click(object sender, EventArgs e)
        {
            controller.AddOwner();
        }
    }
}
