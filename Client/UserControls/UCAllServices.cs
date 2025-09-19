using Client.GuiController.ServiceController;
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
    public partial class UCAllServices : UserControl
    {
        AllServicesController controller;
        public UCAllServices()
        {
            InitializeComponent();
            controller = new AllServicesController(this);
        }



        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            controller.SearchServices();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            controller.EditService();
        }

        private void chckAny_CheckedChanged(object sender, EventArgs e)
        {
            if (controller != null)
            {

                controller.CheckedChanged();
            }
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            controller.ViewGraph();
        }
    }
}
