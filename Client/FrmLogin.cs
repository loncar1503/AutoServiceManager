
using Client.GuiController;
using ComponentFactory.Krypton.Toolkit;

namespace Client
{
    public partial class FrmLogin : KryptonForm
    {


        public FrmLogin()
        {
            LoginGuiController.Instance.frmLogin = this;
            InitializeComponent();
            FrmLoad();
            Program.GlobalPalette = this.kryptonPalette1;
        }

        private void FrmLoad()
        {
            kryptonPalette1.ButtonSpecs.FormRestore.Image = Image.FromFile("Images/maximize.png");
            kryptonPalette1.ButtonSpecs.FormMax.Image = Image.FromFile("Images/maximize.png");
            kryptonPalette1.ButtonSpecs.FormMin.Image = Image.FromFile("Images/minimize.png");
            kryptonPalette1.ButtonSpecs.FormClose.Image = Image.FromFile("Images/exit.png");
        }

        public bool Validacija()
        {


            bool isValid = true;
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.StateActive.Back.Color1 = Color.Salmon;
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.StateActive.Back.Color1 = Color.Salmon;
                isValid = false;
            }
            return isValid;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            LoginGuiController.Instance.Login(sender, e);
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter username")
            {
                txtUsername.Text = "";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter username")
            {
                txtPassword.Text = "";
            }
        }
    }
}
