using Server.Data;

namespace Server
{
    public partial class Form1 : Form
    {
        private Server server;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new Server();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lblStatus.Text = "Server je pokrenut!";
            server.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblStatus.Text = "Server je zaustavljen!";
            server.Stop();
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
