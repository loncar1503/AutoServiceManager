using ComponentFactory.Krypton.Toolkit;

namespace Client.UserControls
{
    partial class UCAddVehicle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtRegBroj = new KryptonTextBox();
            txtGodinaProizv = new KryptonTextBox();
            lblRN = new KryptonLabel();
            lblBrand = new KryptonLabel();
            lblModel = new KryptonLabel();
            cmbMarka = new KryptonComboBox();
            lblDate = new KryptonLabel();
            panel1 = new Panel();
            cmbOwners = new KryptonComboBox();
            txtBrTel = new KryptonTextBox();
            txtPrezime = new KryptonTextBox();
            txtIme = new KryptonTextBox();
            kryptonLabel4 = new KryptonLabel();
            kryptonLabel3 = new KryptonLabel();
            kryptonLabel2 = new KryptonLabel();
            cmbModel = new KryptonComboBox();
            kryptonButton1 = new KryptonButton();
            btnCreateNewOwner = new KryptonButton();
            btnChooseOwner = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)cmbMarka).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbOwners).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbModel).BeginInit();
            SuspendLayout();
            // 
            // txtRegBroj
            // 
            txtRegBroj.Anchor = AnchorStyles.None;
            txtRegBroj.Location = new Point(272, 165);
            txtRegBroj.Name = "txtRegBroj";
            txtRegBroj.Size = new Size(278, 38);
            txtRegBroj.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtRegBroj.StateCommon.Border.Color1 = Color.WhiteSmoke;
            txtRegBroj.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtRegBroj.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtRegBroj.StateCommon.Border.Rounding = 12;
            txtRegBroj.StateCommon.Border.Width = 1;
            txtRegBroj.StateCommon.Content.Font = new Font("Poppins", 9.2F);
            txtRegBroj.TabIndex = 2;
            // 
            // txtGodinaProizv
            // 
            txtGodinaProizv.Anchor = AnchorStyles.None;
            txtGodinaProizv.Location = new Point(269, 432);
            txtGodinaProizv.Name = "txtGodinaProizv";
            txtGodinaProizv.Size = new Size(281, 38);
            txtGodinaProizv.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtGodinaProizv.StateCommon.Border.Color1 = Color.WhiteSmoke;
            txtGodinaProizv.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtGodinaProizv.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtGodinaProizv.StateCommon.Border.Rounding = 12;
            txtGodinaProizv.StateCommon.Border.Width = 1;
            txtGodinaProizv.StateCommon.Content.Font = new Font("Poppins", 9.2F);
            txtGodinaProizv.TabIndex = 4;
            // 
            // lblRN
            // 
            lblRN.Anchor = AnchorStyles.None;
            lblRN.Location = new Point(71, 165);
            lblRN.Name = "lblRN";
            lblRN.Size = new Size(192, 24);
            lblRN.StateCommon.ShortText.Color1 = Color.Orange;
            lblRN.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRN.TabIndex = 5;
            lblRN.Values.Text = "Registration number:";
            // 
            // lblBrand
            // 
            lblBrand.Anchor = AnchorStyles.None;
            lblBrand.Location = new Point(196, 254);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(70, 24);
            lblBrand.StateCommon.ShortText.Color1 = Color.Orange;
            lblBrand.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrand.TabIndex = 6;
            lblBrand.Values.Text = "Brand:";
            // 
            // lblModel
            // 
            lblModel.Anchor = AnchorStyles.None;
            lblModel.Location = new Point(194, 348);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(69, 24);
            lblModel.StateCommon.ShortText.Color1 = Color.Orange;
            lblModel.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModel.TabIndex = 7;
            lblModel.Values.Text = "Model:";
            // 
            // cmbMarka
            // 
            cmbMarka.Anchor = AnchorStyles.None;
            cmbMarka.DropDownWidth = 281;
            cmbMarka.Location = new Point(272, 254);
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
            cmbMarka.TabIndex = 8;
            cmbMarka.SelectedValueChanged += cmbMarka_SelectedValueChanged;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.None;
            lblDate.Location = new Point(88, 432);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(175, 24);
            lblDate.StateCommon.ShortText.Color1 = Color.Orange;
            lblDate.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.TabIndex = 9;
            lblDate.Values.Text = "Year of production:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(60, 60, 60);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtBrTel);
            panel1.Controls.Add(txtPrezime);
            panel1.Controls.Add(txtIme);
            panel1.Controls.Add(kryptonLabel4);
            panel1.Controls.Add(kryptonLabel3);
            panel1.Controls.Add(kryptonLabel2);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(705, 254);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 174);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // cmbOwners
            // 
            cmbOwners.Anchor = AnchorStyles.None;
            cmbOwners.DropDownWidth = 281;
            cmbOwners.Location = new Point(718, 208);
            cmbOwners.Name = "cmbOwners";
            cmbOwners.Size = new Size(353, 40);
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
            // txtBrTel
            // 
            txtBrTel.Anchor = AnchorStyles.None;
            txtBrTel.Location = new Point(144, 116);
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
            // txtPrezime
            // 
            txtPrezime.Anchor = AnchorStyles.None;
            txtPrezime.Location = new Point(144, 65);
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
            // txtIme
            // 
            txtIme.Anchor = AnchorStyles.None;
            txtIme.Location = new Point(144, 11);
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
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.None;
            kryptonLabel4.Location = new Point(54, 65);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(84, 22);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.Orange;
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 14;
            kryptonLabel4.Values.Text = "Surname:";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.None;
            kryptonLabel3.Location = new Point(12, 118);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(126, 22);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.Orange;
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 13;
            kryptonLabel3.Values.Text = "Phone number:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.None;
            kryptonLabel2.Location = new Point(78, 12);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(60, 22);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.Orange;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 12;
            kryptonLabel2.Values.Text = "Name:";
            // 
            // cmbModel
            // 
            cmbModel.Anchor = AnchorStyles.None;
            cmbModel.DropDownWidth = 281;
            cmbModel.Location = new Point(272, 348);
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
            cmbModel.TabIndex = 12;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.None;
            kryptonButton1.Location = new Point(269, 506);
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
            kryptonButton1.TabIndex = 13;
            kryptonButton1.Values.Text = "Add vehicle";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // btnCreateNewOwner
            // 
            btnCreateNewOwner.Anchor = AnchorStyles.None;
            btnCreateNewOwner.Cursor = Cursors.Hand;
            btnCreateNewOwner.Location = new Point(699, 153);
            btnCreateNewOwner.Name = "btnCreateNewOwner";
            btnCreateNewOwner.OverrideDefault.Back.Color1 = Color.Transparent;
            btnCreateNewOwner.OverrideDefault.Back.Color2 = Color.Transparent;
            btnCreateNewOwner.OverrideDefault.Back.Draw = InheritBool.False;
            btnCreateNewOwner.Size = new Size(183, 31);
            btnCreateNewOwner.StateCommon.Back.Color1 = Color.Transparent;
            btnCreateNewOwner.StateCommon.Back.Color2 = Color.Transparent;
            btnCreateNewOwner.StateCommon.Back.Draw = InheritBool.False;
            btnCreateNewOwner.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            btnCreateNewOwner.StateCommon.Content.ShortText.Color1 = Color.Orange;
            btnCreateNewOwner.StateCommon.Content.ShortText.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateNewOwner.StatePressed.Content.ShortText.Color1 = Color.White;
            btnCreateNewOwner.TabIndex = 27;
            btnCreateNewOwner.Values.Text = "Create new owner";
            btnCreateNewOwner.Click += btnCreateNewOwner_Click;
            // 
            // btnChooseOwner
            // 
            btnChooseOwner.Anchor = AnchorStyles.None;
            btnChooseOwner.Cursor = Cursors.Hand;
            btnChooseOwner.Location = new Point(888, 153);
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
            btnChooseOwner.TabIndex = 28;
            btnChooseOwner.Values.Text = "Choose from previous";
            btnChooseOwner.Click += btnChooseOwner_Click;
            // 
            // UCAddVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(cmbOwners);
            Controls.Add(btnChooseOwner);
            Controls.Add(btnCreateNewOwner);
            Controls.Add(kryptonButton1);
            Controls.Add(cmbModel);
            Controls.Add(panel1);
            Controls.Add(lblDate);
            Controls.Add(cmbMarka);
            Controls.Add(lblModel);
            Controls.Add(lblBrand);
            Controls.Add(lblRN);
            Controls.Add(txtGodinaProizv);
            Controls.Add(txtRegBroj);
            Name = "UCAddVehicle";
            Size = new Size(1276, 692);
            ((System.ComponentModel.ISupportInitialize)cmbMarka).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbOwners).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbModel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRegBroj;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGodinaProizv;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblRN;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblBrand;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblModel;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbMarka;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblDate;
        public Panel panel1;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtIme;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBrTel;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPrezime;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbModel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnCreateNewOwner;
        public KryptonButton btnChooseOwner;
        public KryptonComboBox cmbOwners;
    }
}
