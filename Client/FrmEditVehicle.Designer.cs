using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Client
{
    partial class FrmEditVehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            kryptonPalette1 = new KryptonPalette(components);
            kryptonButton1 = new KryptonButton();
            cmbModel = new KryptonComboBox();
            lblDate = new KryptonLabel();
            cmbMarka = new KryptonComboBox();
            lblModel = new KryptonLabel();
            lblBrand = new KryptonLabel();
            lblRN = new KryptonLabel();
            txtGodinaProizv = new KryptonTextBox();
            txtRegBroj = new KryptonTextBox();
            btnChooseOwner = new KryptonButton();
            btnCreateNewOwner = new KryptonButton();
            panel1 = new Panel();
            txtBrTel = new KryptonTextBox();
            txtIme = new KryptonTextBox();
            txtPrezime = new KryptonTextBox();
            kryptonLabel2 = new KryptonLabel();
            kryptonLabel3 = new KryptonLabel();
            kryptonLabel4 = new KryptonLabel();
            cmbOwners = new KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)cmbModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbMarka).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbOwners).BeginInit();
            SuspendLayout();
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.BasePaletteMode = PaletteMode.SparkleOrange;
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = Color.FromArgb(30, 30, 30);
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = Color.FromArgb(30, 30, 30);
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Color1 = Color.FromArgb(30, 30, 30);
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = Color.FromArgb(24, 24, 24);
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = Color.FromArgb(24, 24, 24);
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.ColorAlign = PaletteRectangleAlign.Local;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.ColorStyle = PaletteColorStyle.Solid;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Color1 = Color.FromArgb(30, 30, 30);
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Color2 = Color.FromArgb(30, 30, 30);
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateNormal.Back.Color1 = Color.FromArgb(30, 30, 30);
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateNormal.Back.Color2 = Color.FromArgb(30, 30, 30);
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateNormal.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateNormal.Border.Width = 0;
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = Color.FromArgb(45, 45, 45);
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = Color.FromArgb(45, 45, 45);
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.ColorStyle = PaletteColorStyle.Solid;
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = Color.FromArgb(40, 40, 40);
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = Color.FromArgb(40, 40, 40);
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Width = 0;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(40, 40, 40);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(40, 40, 40);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.None;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 14;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(35, 35, 35);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(35, 35, 35);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new Padding(-1, 8, 8, -1);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(20, -1, -1, -1);
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.None;
            kryptonButton1.Location = new Point(475, 422);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(210, 106, 8);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.OverrideDefault.Border.Rounding = 20;
            kryptonButton1.OverrideDefault.Border.Width = 1;
            kryptonButton1.PaletteMode = PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(273, 56);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(210, 106, 8);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(210, 106, 8);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.Rounding = 20;
            kryptonButton1.StateCommon.Border.Width = 1;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(166, 98, 4);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(87, 51, 2);
            kryptonButton1.StatePressed.Back.ColorAngle = 45F;
            kryptonButton1.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.StatePressed.Border.Rounding = 20;
            kryptonButton1.StatePressed.Border.Width = 1;
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(192, 64, 0);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton1.StateTracking.Back.ColorAngle = 45F;
            kryptonButton1.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.StateTracking.Border.Rounding = 20;
            kryptonButton1.StateTracking.Border.Width = 1;
            kryptonButton1.TabIndex = 24;
            kryptonButton1.Values.Text = "Save changes";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // cmbModel
            // 
            cmbModel.Anchor = AnchorStyles.None;
            cmbModel.DropDownWidth = 281;
            cmbModel.Location = new Point(296, 240);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(281, 40);
            cmbModel.StateCommon.ComboBox.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbModel.StateCommon.ComboBox.Border.Rounding = 20;
            cmbModel.StateCommon.ComboBox.Border.Width = 1;
            cmbModel.StateCommon.ComboBox.Content.Font = new Font("Poppins", 9.2F);
            cmbModel.StateCommon.ComboBox.Content.Padding = new Padding(5, 10, 5, 10);
            cmbModel.StateCommon.Item.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbModel.StateCommon.Item.Border.Rounding = 20;
            cmbModel.StateCommon.Item.Border.Width = 1;
            cmbModel.TabIndex = 23;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.None;
            lblDate.Location = new Point(115, 294);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(175, 24);
            lblDate.StateCommon.ShortText.Color1 = Color.Orange;
            lblDate.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.TabIndex = 20;
            lblDate.Values.Text = "Year of production:";
            // 
            // cmbMarka
            // 
            cmbMarka.Anchor = AnchorStyles.None;
            cmbMarka.DropDownWidth = 281;
            cmbMarka.Location = new Point(296, 177);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(281, 40);
            cmbMarka.StateCommon.ComboBox.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbMarka.StateCommon.ComboBox.Border.Rounding = 20;
            cmbMarka.StateCommon.ComboBox.Border.Width = 1;
            cmbMarka.StateCommon.ComboBox.Content.Font = new Font("Poppins", 9.2F);
            cmbMarka.StateCommon.ComboBox.Content.Padding = new Padding(5, 10, 5, 10);
            cmbMarka.StateCommon.Item.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbMarka.StateCommon.Item.Border.Rounding = 20;
            cmbMarka.StateCommon.Item.Border.Width = 1;
            cmbMarka.TabIndex = 19;
            cmbMarka.SelectedValueChanged += cmbMarka_SelectedValueChanged;
            // 
            // lblModel
            // 
            lblModel.Anchor = AnchorStyles.None;
            lblModel.Location = new Point(221, 240);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(69, 24);
            lblModel.StateCommon.ShortText.Color1 = Color.Orange;
            lblModel.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModel.TabIndex = 18;
            lblModel.Values.Text = "Model:";
            // 
            // lblBrand
            // 
            lblBrand.Anchor = AnchorStyles.None;
            lblBrand.Location = new Point(220, 186);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(70, 24);
            lblBrand.StateCommon.ShortText.Color1 = Color.Orange;
            lblBrand.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrand.TabIndex = 17;
            lblBrand.Values.Text = "Brand:";
            // 
            // lblRN
            // 
            lblRN.Anchor = AnchorStyles.None;
            lblRN.Location = new Point(88, 123);
            lblRN.Name = "lblRN";
            lblRN.Size = new Size(192, 24);
            lblRN.StateCommon.ShortText.Color1 = Color.Orange;
            lblRN.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRN.TabIndex = 16;
            lblRN.Values.Text = "Registration number:";
            // 
            // txtGodinaProizv
            // 
            txtGodinaProizv.Anchor = AnchorStyles.None;
            txtGodinaProizv.Location = new Point(296, 294);
            txtGodinaProizv.Name = "txtGodinaProizv";
            txtGodinaProizv.Size = new Size(281, 38);
            txtGodinaProizv.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtGodinaProizv.StateCommon.Border.Color1 = Color.WhiteSmoke;
            txtGodinaProizv.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtGodinaProizv.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtGodinaProizv.StateCommon.Border.Rounding = 12;
            txtGodinaProizv.StateCommon.Border.Width = 1;
            txtGodinaProizv.StateCommon.Content.Font = new Font("Poppins", 9.2F);
            txtGodinaProizv.TabIndex = 15;
            // 
            // txtRegBroj
            // 
            txtRegBroj.Anchor = AnchorStyles.None;
            txtRegBroj.Location = new Point(296, 123);
            txtRegBroj.Name = "txtRegBroj";
            txtRegBroj.Size = new Size(278, 38);
            txtRegBroj.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtRegBroj.StateCommon.Border.Color1 = Color.WhiteSmoke;
            txtRegBroj.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtRegBroj.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtRegBroj.StateCommon.Border.Rounding = 12;
            txtRegBroj.StateCommon.Border.Width = 1;
            txtRegBroj.StateCommon.Content.Font = new Font("Poppins", 9.2F);
            txtRegBroj.TabIndex = 14;
            // 
            // btnChooseOwner
            // 
            btnChooseOwner.Anchor = AnchorStyles.None;
            btnChooseOwner.Cursor = Cursors.Hand;
            btnChooseOwner.Location = new Point(940, 104);
            btnChooseOwner.Name = "btnChooseOwner";
            btnChooseOwner.OverrideDefault.Back.Color1 = Color.Transparent;
            btnChooseOwner.OverrideDefault.Back.Color2 = Color.Transparent;
            btnChooseOwner.OverrideDefault.Back.Draw = InheritBool.False;
            btnChooseOwner.Size = new Size(201, 31);
            btnChooseOwner.StateCommon.Back.Color1 = Color.Transparent;
            btnChooseOwner.StateCommon.Back.Color2 = Color.Transparent;
            btnChooseOwner.StateCommon.Back.Draw = InheritBool.False;
            btnChooseOwner.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            btnChooseOwner.StateCommon.Content.ShortText.Color1 = Color.Orange;
            btnChooseOwner.StateCommon.Content.ShortText.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChooseOwner.StatePressed.Content.ShortText.Color1 = Color.White;
            btnChooseOwner.TabIndex = 32;
            btnChooseOwner.Values.Text = "Choose from previous";
            btnChooseOwner.Click += btnChooseOwner_Click;
            // 
            // btnCreateNewOwner
            // 
            btnCreateNewOwner.Anchor = AnchorStyles.None;
            btnCreateNewOwner.Cursor = Cursors.Hand;
            btnCreateNewOwner.Location = new Point(751, 104);
            btnCreateNewOwner.Name = "btnCreateNewOwner";
            btnCreateNewOwner.OverrideDefault.Back.Color1 = Color.Transparent;
            btnCreateNewOwner.OverrideDefault.Back.Color2 = Color.Transparent;
            btnCreateNewOwner.OverrideDefault.Back.Draw = InheritBool.False;
            btnCreateNewOwner.Size = new Size(173, 31);
            btnCreateNewOwner.StateCommon.Back.Color1 = Color.Transparent;
            btnCreateNewOwner.StateCommon.Back.Color2 = Color.Transparent;
            btnCreateNewOwner.StateCommon.Back.Draw = InheritBool.False;
            btnCreateNewOwner.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            btnCreateNewOwner.StateCommon.Content.ShortText.Color1 = Color.Orange;
            btnCreateNewOwner.StateCommon.Content.ShortText.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateNewOwner.StatePressed.Content.ShortText.Color1 = Color.White;
            btnCreateNewOwner.TabIndex = 31;
            btnCreateNewOwner.Values.Text = "Create new owner";
            btnCreateNewOwner.Click += btnCreateNewOwner_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(60, 60, 60);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtBrTel);
            panel1.Controls.Add(txtIme);
            panel1.Controls.Add(txtPrezime);
            panel1.Controls.Add(kryptonLabel2);
            panel1.Controls.Add(kryptonLabel3);
            panel1.Controls.Add(kryptonLabel4);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(756, 201);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 175);
            panel1.TabIndex = 29;
            // 
            // txtBrTel
            // 
            txtBrTel.Anchor = AnchorStyles.None;
            txtBrTel.Location = new Point(138, 118);
            txtBrTel.Name = "txtBrTel";
            txtBrTel.Size = new Size(195, 38);
            txtBrTel.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtBrTel.StateCommon.Border.Color1 = Color.WhiteSmoke;
            txtBrTel.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtBrTel.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtBrTel.StateCommon.Border.Rounding = 12;
            txtBrTel.StateCommon.Border.Width = 1;
            txtBrTel.StateCommon.Content.Font = new Font("Poppins", 9.2F);
            txtBrTel.TabIndex = 16;
            // 
            // txtIme
            // 
            txtIme.Anchor = AnchorStyles.None;
            txtIme.Location = new Point(138, 13);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(195, 38);
            txtIme.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtIme.StateCommon.Border.Color1 = Color.WhiteSmoke;
            txtIme.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtIme.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtIme.StateCommon.Border.Rounding = 12;
            txtIme.StateCommon.Border.Width = 1;
            txtIme.StateCommon.Content.Font = new Font("Poppins", 9.2F);
            txtIme.TabIndex = 12;
            // 
            // txtPrezime
            // 
            txtPrezime.Anchor = AnchorStyles.None;
            txtPrezime.Location = new Point(138, 67);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(195, 38);
            txtPrezime.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtPrezime.StateCommon.Border.Color1 = Color.WhiteSmoke;
            txtPrezime.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtPrezime.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtPrezime.StateCommon.Border.Rounding = 12;
            txtPrezime.StateCommon.Border.Width = 1;
            txtPrezime.StateCommon.Content.Font = new Font("Poppins", 9.2F);
            txtPrezime.TabIndex = 15;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.None;
            kryptonLabel2.Location = new Point(72, 14);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(60, 22);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.Orange;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 12;
            kryptonLabel2.Values.Text = "Name:";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.None;
            kryptonLabel3.Location = new Point(6, 120);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(126, 22);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.Orange;
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 13;
            kryptonLabel3.Values.Text = "Phone number:";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.None;
            kryptonLabel4.Location = new Point(48, 67);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(84, 22);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.Orange;
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 14;
            kryptonLabel4.Values.Text = "Surname:";
            // 
            // cmbOwners
            // 
            cmbOwners.Anchor = AnchorStyles.None;
            cmbOwners.DropDownWidth = 281;
            cmbOwners.Location = new Point(786, 141);
            cmbOwners.Name = "cmbOwners";
            cmbOwners.Size = new Size(317, 40);
            cmbOwners.StateCommon.ComboBox.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbOwners.StateCommon.ComboBox.Border.Rounding = 20;
            cmbOwners.StateCommon.ComboBox.Border.Width = 1;
            cmbOwners.StateCommon.ComboBox.Content.Font = new Font("Poppins", 9.2F);
            cmbOwners.StateCommon.ComboBox.Content.Padding = new Padding(5, 10, 5, 10);
            cmbOwners.StateCommon.Item.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbOwners.StateCommon.Item.Border.Rounding = 20;
            cmbOwners.StateCommon.Item.Border.Width = 1;
            cmbOwners.TabIndex = 29;
            // 
            // FrmEditVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1200, 600);
            Controls.Add(cmbOwners);
            Controls.Add(btnChooseOwner);
            Controls.Add(btnCreateNewOwner);
            Controls.Add(panel1);
            Controls.Add(kryptonButton1);
            Controls.Add(cmbModel);
            Controls.Add(lblDate);
            Controls.Add(cmbMarka);
            Controls.Add(lblModel);
            Controls.Add(lblBrand);
            Controls.Add(lblRN);
            Controls.Add(txtGodinaProizv);
            Controls.Add(txtRegBroj);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(2, 3, 2, 3);
            Name = "FrmEditVehicle";
            Palette = kryptonPalette1;
            PaletteMode = PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit vehicle";
            ((System.ComponentModel.ISupportInitialize)cmbModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbMarka).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbOwners).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private KryptonButton kryptonButton1;
        public KryptonComboBox cmbModel;
        public KryptonLabel lblDate;
        public KryptonComboBox cmbMarka;
        public KryptonLabel lblModel;
        public KryptonLabel lblBrand;
        public KryptonLabel lblRN;
        public KryptonTextBox txtGodinaProizv;
        public KryptonTextBox txtRegBroj;
        public KryptonButton btnChooseOwner;
        public KryptonButton btnCreateNewOwner;
        public Panel panel1;
        public KryptonComboBox cmbOwners;
        public KryptonTextBox txtBrTel;
        public KryptonTextBox txtPrezime;
        public KryptonTextBox txtIme;
        public KryptonLabel kryptonLabel4;
        public KryptonLabel kryptonLabel3;
        public KryptonLabel kryptonLabel2;
    }
}