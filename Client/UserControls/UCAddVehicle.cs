using Client.GuiController.VehicleController;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCAddVehicle : UserControl
    {
        AddVehicleController controller;
        
        public UCAddVehicle()
        {
            InitializeComponent();
            controller = new AddVehicleController(this);
        }

        


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Definišemo zaobljene ivice
            int borderRadius = 20; // Radijus zaobljenja
            GraphicsPath path = new GraphicsPath();

            // Dodajemo zaobljene ivice na panel
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90); // Gornji levi ugao
            path.AddArc(panel1.Width - borderRadius - 1, 0, borderRadius, borderRadius, 270, 90); // Gornji desni ugao
            path.AddArc(panel1.Width - borderRadius - 1, panel1.Height - borderRadius - 1, borderRadius, borderRadius, 0, 90); // Donji desni ugao
            path.AddArc(0, panel1.Height - borderRadius - 1, borderRadius, borderRadius, 90, 90); // Donji levi ugao
            path.CloseFigure(); // Zatvara oblik

            // Nacrtaj pozadinu panela sa zaobljenim ivicama
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillPath(new SolidBrush(panel1.BackColor), path);

            // Nacrtaj ivicu panela (ako želiš ivicu)
            e.Graphics.DrawPath(new Pen(panel1.ForeColor), path);
        }

        private void cmbMarka_SelectedValueChanged(object sender, EventArgs e)
        {
            if (controller == null)
            {
                controller = new AddVehicleController(this);
            }
            if (cmbMarka.SelectedItem != null)
            {

                controller.FillCMBModel((Marka)cmbMarka.SelectedItem);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            controller.AddVehicle();
        }

        private void btnChooseOwner_Click(object sender, EventArgs e)
        {
            controller.chooseFromPreviousSelected();
        }

        private void btnCreateNewOwner_Click(object sender, EventArgs e)
        {
            controller.createNewSelected();
        }

     
    }
}
