using Client.GuiController.ServiceController;
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
    public partial class FrmEditService : KryptonForm
    {
        EditServiceController controller;
        Servis service;
        public FrmEditService(Servis service)
        {
            this.service = service;
            InitializeComponent();
            controller = new EditServiceController(this, service);
            FrmLoad();
        }
        private void FrmLoad()
        {
            kryptonPalette1.ButtonSpecs.FormRestore.Image = Image.FromFile("Images/maximize.png");
            kryptonPalette1.ButtonSpecs.FormMax.Image = Image.FromFile("Images/maximize.png");
            kryptonPalette1.ButtonSpecs.FormMin.Image = Image.FromFile("Images/minimize.png");
            kryptonPalette1.ButtonSpecs.FormClose.Image = Image.FromFile("Images/exit.png");


        }

        private void btnDodajUslugu_Click(object sender, EventArgs e)
        {
            controller.AddServiceItem();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            controller.DeleteServiceItem();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            controller.SaveServiceChanges();
        }
    }
}
