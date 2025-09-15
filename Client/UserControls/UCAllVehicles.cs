using Client.GuiController.VehicleController;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCAllVehicles : UserControl
    {
        AllVehicleController controller;
        public UCAllVehicles()
        {
            InitializeComponent();
            controller = new AllVehicleController(this);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            controller.Search();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            controller.EditForm();

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            controller.DeleteVehicle();
        }
    }
}
