using Client.GuiController.Licence;
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
    public partial class UCAddLicence : UserControl
    {
        AddLicenceController controller;
        public Majstor majstor;
        public UCAddLicence(Majstor majstor)
        {
            InitializeComponent();
            this.majstor = majstor;
            controller = new AddLicenceController(this);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            controller.SaveLicence();
        }
    }
}
