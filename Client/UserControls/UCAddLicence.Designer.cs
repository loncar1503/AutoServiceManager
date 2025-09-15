namespace Client.UserControls
{
    partial class UCAddLicence
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
            cmbInstitution = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            cmbCategory = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            lblRN = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            txtName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)cmbInstitution).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbCategory).BeginInit();
            SuspendLayout();
            // 
            // cmbInstitution
            // 
            cmbInstitution.Anchor = AnchorStyles.None;
            cmbInstitution.DropDownWidth = 281;
            cmbInstitution.Location = new Point(403, 230);
            cmbInstitution.Name = "cmbInstitution";
            cmbInstitution.Size = new Size(281, 50);
            cmbInstitution.StateCommon.ComboBox.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbInstitution.StateCommon.ComboBox.Border.Rounding = 20;
            cmbInstitution.StateCommon.ComboBox.Border.Width = 1;
            cmbInstitution.StateCommon.ComboBox.Content.Padding = new Padding(5, 10, 5, 10);
            cmbInstitution.StateCommon.ComboBox.Content.Font = new Font("Poppins", 9.2f, FontStyle.Regular);
            cmbInstitution.StateCommon.Item.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbInstitution.StateCommon.Item.Border.Rounding = 20;
            cmbInstitution.StateCommon.Item.Border.Width = 1;
            cmbInstitution.TabIndex = 21;
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.None;
            cmbCategory.DropDownWidth = 281;
            cmbCategory.Location = new Point(403, 326);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(281, 50);
            cmbCategory.StateCommon.ComboBox.Content.Padding = new Padding(5, 10, 5, 10);
            cmbCategory.StateCommon.ComboBox.Content.Font = new Font("Poppins", 9.2f, FontStyle.Regular);
            cmbCategory.StateCommon.ComboBox.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbCategory.StateCommon.ComboBox.Border.Rounding = 20;
            cmbCategory.StateCommon.ComboBox.Border.Width = 1;
            cmbCategory.StateCommon.Item.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbCategory.StateCommon.Item.Border.Rounding = 20;
            cmbCategory.StateCommon.Item.Border.Width = 1;
            cmbCategory.TabIndex = 22;
            // 
            // lblRN
            // 
            lblRN.Anchor = AnchorStyles.None;
            lblRN.Location = new Point(182, 141);
            lblRN.Name = "lblRN";
            lblRN.Size = new Size(136, 24);
            lblRN.StateCommon.ShortText.Color1 = Color.Orange;
            lblRN.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRN.TabIndex = 23;
            lblRN.Values.Text = "Licence name:";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Anchor = AnchorStyles.None;
            kryptonLabel1.Location = new Point(182, 230);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(160, 24);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.Orange;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 24;
            kryptonLabel1.Values.Text = "Issuing authority:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.None;
            kryptonLabel2.Location = new Point(182, 335);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(166, 24);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.Orange;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 25;
            kryptonLabel2.Values.Text = "Licence category:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Location = new Point(403, 141);
            txtName.Name = "txtName";
            txtName.Size = new Size(278, 35);
            txtName.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtName.StateCommon.Border.Color1 = Color.WhiteSmoke;
            txtName.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            txtName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtName.StateCommon.Border.Rounding = 12;
            txtName.StateCommon.Border.Width = 1;
            txtName.StateCommon.Content.Font = new Font("Poppins", 9.2f, FontStyle.Regular);
            txtName.TabIndex = 26;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.None;
            kryptonButton1.Location = new Point(403, 448);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(210, 106, 8);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.OverrideDefault.Border.Rounding = 20;
            kryptonButton1.OverrideDefault.Border.Width = 1;
            kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(273, 56);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(210, 106, 8);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(210, 106, 8);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.Rounding = 20;
            kryptonButton1.StateCommon.Border.Width = 1;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(166, 98, 4);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(87, 51, 2);
            kryptonButton1.StatePressed.Back.ColorAngle = 45F;
            kryptonButton1.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StatePressed.Border.Rounding = 20;
            kryptonButton1.StatePressed.Border.Width = 1;
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(192, 64, 0);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton1.StateTracking.Back.ColorAngle = 45F;
            kryptonButton1.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateTracking.Border.Rounding = 20;
            kryptonButton1.StateTracking.Border.Width = 1;
            kryptonButton1.TabIndex = 27;
            kryptonButton1.Values.Text = "Add Licence";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // UCAddLicence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(kryptonButton1);
            Controls.Add(txtName);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(lblRN);
            Controls.Add(cmbCategory);
            Controls.Add(cmbInstitution);
            Name = "UCAddLicence";
            Size = new Size(1142, 627);
            ((System.ComponentModel.ISupportInitialize)cmbInstitution).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbInstitution;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCategory;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblRN;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}
