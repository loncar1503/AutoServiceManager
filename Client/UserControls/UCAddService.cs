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
    public partial class UCAddService : UserControl
    {
        AddServiceController controller;
        public UCAddService()
        {
            InitializeComponent();
            controller = new AddServiceController(this);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            controller.AddService();
        }

        private void btnDodajUslugu_Click(object sender, EventArgs e)
        {
            controller.AddServiceItem();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            controller.DeleteServiceItem();
        }
    }
}
