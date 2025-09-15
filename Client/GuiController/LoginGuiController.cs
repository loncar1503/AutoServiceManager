using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client.GuiController
{
    public class LoginGuiController
    {

        private static LoginGuiController instance;
        public static LoginGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginGuiController();
                }
                return instance;
            }
        }
        private LoginGuiController()
        {
        }

        internal FrmLogin frmLogin;

        public void Login(object sender, EventArgs e)
        {
            try
            {
                if (!frmLogin.Validacija())
                {
                    MessageBox.Show("Molimo popunite sva polja.");
                    return;
                }
                Communication.Instance.Connect();
                Majstor m = new Majstor
                {
                    Username = frmLogin.txtUsername.Text,
                    Password = frmLogin.txtPassword.Text,
                };
                Response response = Communication.Instance.Login(m);
                if (response.ExceptionMessage == null)
                {
                    frmLogin.Visible = false;
                    FrmMain frmMain = new FrmMain((Majstor)response.Result);
                    frmMain.AutoSize = true;
                    frmMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show(response.ExceptionMessage);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Server is not started");;
            }
        }
    }
}
