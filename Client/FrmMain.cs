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
using ComponentFactory.Krypton.Toolkit;
using System.Drawing.Drawing2D;
using Client.UserControls;
using Common.Domain;

namespace Client
{
    public partial class FrmMain : KryptonForm
    {
        private const int GAP = 32; 
        Majstor majstor;

        public FrmMain(Majstor majstor)
        {
            InitializeComponent();
            this.majstor = majstor;
            this.Load += Form1_Load;
            this.Shown += (s, e) => CenterMenu(menuStrip1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kryptonPalette1.ButtonSpecs.FormRestore.Image = Image.FromFile("Images/maximize.png");
            kryptonPalette1.ButtonSpecs.FormMax.Image = Image.FromFile("Images/maximize.png");
            kryptonPalette1.ButtonSpecs.FormMin.Image = Image.FromFile("Images/minimize.png");
            kryptonPalette1.ButtonSpecs.FormClose.Image = Image.FromFile("Images/exit.png");



            this.WindowState = FormWindowState.Maximized;

            var menu = menuStrip1;
            menu.SuspendLayout();

            // Osnovni izgled
            menu.AutoSize = false;
            menu.Height = 44;
            menu.Dock = DockStyle.Top;
            menu.BackColor = Color.FromArgb(40,40,40);
            menu.ForeColor = Color.Orange; // fallback
            menu.Font = new Font("Poppins ExtraBold", 11.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);; // ako nema Poppins, koristiće fallback font
            menu.Renderer = new DarkMenuRenderer(Color.FromArgb(40, 40, 40), Color.Orange);
            menu.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menu.Padding = new Padding(0);
            menu.Margin = new Padding(0);

            // Očisti postojeće iteme (ako ih ima iz dizajnera)
            menu.Items.Clear();

            var reservations = new ToolStripMenuItem("Services");
            reservations.DropDownItems.Add(new ToolStripMenuItem("All Services", null, OnAllReservations));
            reservations.DropDownItems.Add(new ToolStripMenuItem("Add Service", null, OnAddReservation));
            ConfigureDropDown(reservations);

            var vehicles = new ToolStripMenuItem("Vehicles");
            vehicles.DropDownItems.Add(new ToolStripMenuItem("All Vehicles", null, OnAllVehicles));
            vehicles.DropDownItems.Add(new ToolStripMenuItem("Add Vehicles", null, OnAddVehicle));
            ConfigureDropDown(vehicles);

            var licences = new ToolStripMenuItem("Licences");
            licences.DropDownItems.Add(new ToolStripMenuItem("Add Licence", null, OnAddLicence));
            ConfigureDropDown(licences);

            menu.Items.AddRange(new ToolStripItem[] { reservations, vehicles, licences });
            ApplyTopLevelSpacing(menu); // doda razmak oko glavnih stavki


            // Centriranje stavki na vrhu
            menu.Layout += (s, e2) => { ApplyTopLevelSpacing(menu); CenterMenu(menu); };
            this.Resize += (s, e2) => CenterMenu(menu);
            CenterMenu(menu);

            menu.ResumeLayout();
        }

        // Dropdown da bude bez ikonica/margina, ista tamna pozadina i beli tekst
        private void ConfigureDropDown(ToolStripMenuItem root)
        {
            var dd = (ToolStripDropDownMenu)root.DropDown;
            dd.BackColor = Color.FromArgb(40, 40, 40); 
            dd.ForeColor = Color.White;
            dd.ShowCheckMargin = false;
            dd.ShowImageMargin = false;
            dd.Renderer = menuStrip1.Renderer; // isti renderer radi konzistentnosti
            foreach (ToolStripItem it in root.DropDownItems) it.ForeColor = Color.White;
        }
        private void ApplyTopLevelSpacing(MenuStrip ms)
        {
            const int PAD = 20; // koliki unutrašnji razmak oko teksta (povećaj/smanji po želji)

            foreach (ToolStripItem it in ms.Items)
            {
                it.AutoSize = true;             // dozvoli da širina prati padding
                it.Margin = Padding.Empty;      // marginu zanemari
                it.Padding = new Padding(PAD, 0, PAD, 0); // OVO pravi vidljiv razmak
            }
        }

        // Izračun levo paddinga tako da su itemi optički centrirani
        private void CenterMenu(MenuStrip ms)
        {
            int total = 0;
            foreach (ToolStripItem i in ms.Items)
                if (i.Available) total += i.Width;

            int left = Math.Max(0, (ms.Width - total) / 2);
            ms.Padding = new Padding(left, 0, 0, 0);
        }

        private void OnAllReservations(object s, EventArgs e) {
            pnlMain.Controls.Clear();
            UCAllServices uCAllServices = new UCAllServices()
            {
                Dock = DockStyle.Fill,
            };
            pnlMain.Controls.Add(uCAllServices);
        }
        private void OnAddReservation(object s, EventArgs e) {
            pnlMain.Controls.Clear();
            UCAddService ucAddService = new UCAddService()
            {
                Dock = DockStyle.Fill,
            };
            pnlMain.Controls.Add(ucAddService);
        }
        private void OnAllVehicles(object s, EventArgs e) { 
            pnlMain.Controls.Clear();
            UCAllVehicles ucAllVehicles= new UCAllVehicles()
            {
                Dock=DockStyle.Fill,
            };
            pnlMain.Controls.Add(ucAllVehicles);

        }
        private void OnAddVehicle(object s, EventArgs e) { 
            pnlMain.Controls.Clear();
            UCAddVehicle ucAddVehicle= new UCAddVehicle()
            {
                Dock = DockStyle.Fill,
            };
            pnlMain.Controls.Add(ucAddVehicle);
        }
        private void OnAddLicence(object s, EventArgs e) {
            pnlMain.Controls.Clear();
            UCAddLicence uCAddLicence = new UCAddLicence(majstor)
            {
                Dock = DockStyle.Fill,
            };
            pnlMain.Controls.Add(uCAddLicence);
        }

        private sealed class DarkMenuRenderer : ToolStripProfessionalRenderer
        {
            private readonly Color bg;
            private readonly Color topText;

            public DarkMenuRenderer(Color background, Color topTextColor)
                : base(new DarkColorTable(background))
            {
                bg = background;
                topText = topTextColor;
            }

            protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
            {
                e.Graphics.Clear(bg);
            }

            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                using var b = new SolidBrush(bg);
                e.Graphics.FillRectangle(b, new Rectangle(Point.Empty, e.Item.Size));
            }

            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                // Narandžast tekst za top-level, beli za dropdown
                bool topLevel = e.ToolStrip is MenuStrip;
                e.TextColor = topLevel
                    ? (e.Item.Selected ? Color.White : topText)      // hover na glavnim stavkama
                    : (e.Item.Selected ? Color.Gray : Color.White); // hover u dropdownu
                base.OnRenderItemText(e);
            }

            protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
            {
                e.ArrowColor = Color.White; // strelice u dropdownu bele
                base.OnRenderArrow(e);
            }

            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
            {
                // bez bordera
            }

            private sealed class DarkColorTable : ProfessionalColorTable
            {
                private readonly Color bg;
                public DarkColorTable(Color background) { bg = background; UseSystemColors = false; }
                public override Color MenuStripGradientBegin => bg;
                public override Color MenuStripGradientEnd => bg;
                public override Color ToolStripDropDownBackground => bg;
                public override Color ImageMarginGradientBegin => bg;
                public override Color ImageMarginGradientMiddle => bg;
                public override Color ImageMarginGradientEnd => bg;
                public override Color MenuItemBorder => bg;
                public override Color MenuItemPressedGradientBegin => bg;
                public override Color MenuItemPressedGradientEnd => bg;
                public override Color MenuItemSelected => bg;
                public override Color MenuItemSelectedGradientBegin => bg;
                public override Color MenuItemSelectedGradientEnd => bg;
            }
        }
    }


        #region newerOldForm
        //public FrmMain()
        //{
        //    InitializeComponent();
        //    Load += FrmMain_Load;
        //}

        //// ---------- PUBLIC UI ACTIONS (prazne za sada) ----------
        //private void CreateReservation() { MessageBox.Show("Create reservation"); }
        //private void SearchReservation() { MessageBox.Show("Search reservation"); }
        //private void EditReservation() { MessageBox.Show("Edit reservation"); }
        //private void CreateVehicle() { MessageBox.Show("Create vehicle"); }
        //private void SearchVehicle() { MessageBox.Show("Search vehicle"); }
        //private void DeleteVehicle() { MessageBox.Show("Delete vehicle"); }

        //// ---------- LOAD ----------
        //private void FrmMain_Load(object sender, EventArgs e)
        //{
        //    // 1) Fullscreen
        //    WindowState = FormWindowState.Maximized;

        //    // 2) Ikonice prozora (čitati iz foldera aplikacije)
        //    try
        //    {
        //        kryptonPalette1.ButtonSpecs.FormRestore.Image = Image.FromFile("Images/maximize.png");
        //        kryptonPalette1.ButtonSpecs.FormMax.Image = Image.FromFile("Images/maximize.png");
        //        kryptonPalette1.ButtonSpecs.FormMin.Image = Image.FromFile("Images/minimize.png");
        //        kryptonPalette1.ButtonSpecs.FormClose.Image = Image.FromFile("Images/exit.png");
        //    }
        //    catch { /* ignorisi ako fali fajl */ }

        //    // 3) MenuStrip – dock i dimenzije
        //    menuStrip1.Dock = DockStyle.Top;
        //    menuStrip1.AutoSize = false;
        //    menuStrip1.Stretch = true;
        //    menuStrip1.Height = 44;

        //    // 4) Boje i font
        //    var poppins = SafeFont("Poppins", 10f, FontStyle.Regular);
        //    menuStrip1.Font = poppins;
        //    menuStrip1.RenderMode = ToolStripRenderMode.Professional; // da prihvati boje na itemima
        //    menuStrip1.BackColor = Color.Orange;
        //    menuStrip1.ForeColor = Color.White;

        //    // 5) Napravi klikabilne “dugmiće”
        //    menuStrip1.Items.Clear();
        //    menuStrip1.Items.AddRange(new ToolStripMenuItem[]
        //    {
        //        Btn("Create reservation",   (s,e)=>CreateReservation(), poppins),
        //        Btn("Search for reservation",(s,e)=>SearchReservation(), poppins),
        //        Btn("Edit reservation",     (s,e)=>EditReservation(), poppins),
        //        Btn("Vehicles",             (s,e)=>CreateVehicle(), poppins),
        //        Btn("Search for vehicle",   (s,e)=>SearchVehicle(), poppins),
        //        Btn("Delete vehicle",       (s,e)=>DeleteVehicle(), poppins)
        //    });

        //    // 6) Centriranje stavki (i održavanje pri resize/layout)
        //    menuStrip1.Layout += (s, ev) => CenterMenu();
        //    menuStrip1.SizeChanged += (s, ev) => { RoundMenuStrip(menuStrip1, 8); CenterMenu(); };
        //    this.Resize += (s, ev) => CenterMenu();

        //    // odloži prvi layout da širine itema budu tačne
        //    BeginInvoke((MethodInvoker)(() => { RoundMenuStrip(menuStrip1, 8); CenterMenu(); }));
        //}

        //// ---------- POMOĆNI KREATOR STAVKI (izgled kao dugme) ----------
        //private ToolStripMenuItem Btn(string text, EventHandler onClick, Font f)
        //{
        //    var it = new ToolStripMenuItem(text);
        //    it.Font = f;
        //    it.ForeColor = Color.White;
        //    it.BackColor = Color.Orange;          // radi uz Professional renderer
        //    it.AutoSize = true;
        //    it.Margin = Padding.Empty;
        //    it.Padding = new Padding(14, 10, 14, 10); // “dugme” look
        //    it.Click += onClick;
        //    return it;
        //}

        //// ---------- CENTRIRANJE ----------
        //private void CenterMenu()
        //{
        //    if (menuStrip1.Items.Count == 0) return;

        //    int total = menuStrip1.Items.Cast<ToolStripItem>()
        //                 .Sum(i => i.Width + i.Margin.Horizontal);

        //    int lr = Math.Max(0, (menuStrip1.Width - total) / 2);
        //    menuStrip1.Padding = new Padding(lr, 0, lr, 0);
        //}

        //// ---------- ZAOBLJENI UGLovi ----------
        //private void RoundMenuStrip(MenuStrip menu, int radius)
        //{
        //    if (menu.Width <= 0 || menu.Height <= 0) return;

        //    using var path = new GraphicsPath();
        //    int d = radius * 2;
        //    var r = new Rectangle(0, 0, menu.Width, menu.Height);

        //    path.AddArc(r.X, r.Y, d, d, 180, 90);
        //    path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
        //    path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
        //    path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
        //    path.CloseFigure();

        //    menu.Region = new Region(path);
        //}

        //// ---------- FONT FALLBACK ----------
        //private static Font SafeFont(string family, float size, FontStyle style)
        //{
        //    try { return new Font(family, size, style); }
        //    catch { return new Font("Segoe UI", size, style); }
        //}
        #endregion
        #region oldForm

        //public FrmMain()
        //{
        //    InitializeComponent();
        //    this.Load += Form1_Load;

        //}




        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Maximized;
        //    RoundMenuStrip(menuStrip1, 8);
        //    menuStrip1.Dock = DockStyle.Top;
        //    menuStrip1.Stretch = true;
        //    kryptonPalette1.ButtonSpecs.FormRestore.Image = Image.FromFile("Images/maximize.png");
        //    kryptonPalette1.ButtonSpecs.FormMax.Image = Image.FromFile("Images/maximize.png");
        //    kryptonPalette1.ButtonSpecs.FormMin.Image = Image.FromFile("Images/minimize.png");
        //    kryptonPalette1.ButtonSpecs.FormClose.Image = Image.FromFile("Images/exit.png");
        //    menuStrip1.RenderMode = ToolStripRenderMode.Professional;
        //    // Stavke
        //    menuStrip1.Items.Clear();
        //    menuStrip1.Items.Add("Create reservation");
        //    menuStrip1.Items.Add("Search for reservation");
        //    menuStrip1.Items.Add("Edit reservation");
        //    menuStrip1.Items.Add("Vehicles");
        //    menuStrip1.Items.Add("Search for vehicle");
        //    menuStrip1.Items.Add("Delete vehicle");

        //    // Osnovni izgled
        //    menuStrip1.Font = new Font("Poppins", 10, FontStyle.Regular);
        //    menuStrip1.BackColor = Color.Orange;
        //    menuStrip1.ForeColor = Color.White;
        //    menuStrip1.AutoSize = false;
        //    menuStrip1.Height = 40;


        //    // Krypton ponekad ignoriše ForeColor na itemima → primeni na svakoj stavci
        //    foreach (ToolStripMenuItem item in menuStrip1.Items)
        //    {
        //        item.ForeColor = Color.White;
        //    }

        //    // Centriranje stavki
        //    menuStrip1.Layout += (s, ev) =>
        //    {
        //        int totalItemWidth = menuStrip1.Items.Cast<ToolStripItem>().Sum(i => (int)i.Width);
        //        menuStrip1.Padding = new Padding((menuStrip1.Width - totalItemWidth) / 2, 0, 0, 0);
        //    };
        //}

        //private void RoundMenuStrip(MenuStrip menu, int radius)
        //{
        //    GraphicsPath path = new GraphicsPath();
        //    int arcDiameter = radius * 2;
        //    Rectangle bounds = new Rectangle(0, 0, menu.Width, menu.Height);

        //    // Gornji levi
        //    path.AddArc(bounds.X, bounds.Y, arcDiameter, arcDiameter, 180, 90);
        //    // Gornji desni
        //    path.AddArc(bounds.Right - arcDiameter, bounds.Y, arcDiameter, arcDiameter, 270, 90);
        //    // Donji desni
        //    path.AddArc(bounds.Right - arcDiameter, bounds.Bottom - arcDiameter, arcDiameter, arcDiameter, 0, 90);
        //    // Donji levi
        //    path.AddArc(bounds.X, bounds.Bottom - arcDiameter, arcDiameter, arcDiameter, 90, 90);
        //    path.CloseFigure();

        //    menu.Region = new Region(path);
        //}
        #endregion

}

