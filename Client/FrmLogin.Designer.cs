using ComponentFactory.Krypton.Toolkit;

namespace Client
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            kryptonPalette1 = new KryptonPalette(components);
            kryptonButton1 = new KryptonButton();
            txtUsername = new KryptonTextBox();
            txtPassword = new KryptonTextBox();
            kryptonLabel1 = new KryptonLabel();
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
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = Color.FromArgb(30, 30, 30);
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = Color.FromArgb(30, 30, 30);
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.ColorStyle = PaletteColorStyle.Solid;
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Draw = InheritBool.True;
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.GraphicsHint = PaletteGraphicsHint.None;
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
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = Color.FromArgb(255, 128, 0);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.ColorStyle = PaletteColorStyle.Solid;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new Font("Broadway", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.None;
            kryptonButton1.Location = new Point(278, 250);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(210, 106, 8);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.OverrideDefault.Border.Rounding = 20;
            kryptonButton1.OverrideDefault.Border.Width = 1;
            kryptonButton1.PaletteMode = PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(162, 51);
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
            kryptonButton1.TabIndex = 0;
            kryptonButton1.Values.Text = "Login";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(233, 121);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(251, 35);
            txtUsername.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtUsername.StateCommon.Border.Color1 = Color.WhiteSmoke;
            txtUsername.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtUsername.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtUsername.StateCommon.Border.Rounding = 12;
            txtUsername.StateCommon.Border.Width = 1;
            txtUsername.StateCommon.Content.Color1 = Color.DimGray;
            txtUsername.TabIndex = 1;
            txtUsername.Enter += txtUsername_Enter;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(233, 183);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(251, 35);
            txtPassword.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtPassword.StateCommon.Border.Color1 = Color.WhiteSmoke;
            txtPassword.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtPassword.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtPassword.StateCommon.Border.Rounding = 12;
            txtPassword.StateCommon.Content.Color1 = Color.DimGray;
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Enter += txtPassword_Enter;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(244, 38);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(229, 53);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(255, 128, 0);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Poppins ExtraBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 3;
            kryptonLabel1.Values.Text = "Please login";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(730, 376);
            Controls.Add(kryptonLabel1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(kryptonButton1);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(2, 3, 2, 3);
            Name = "FrmLogin";
            Palette = kryptonPalette1;
            PaletteMode = PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = Color.FromArgb(40, 40, 40);
            StateCommon.Back.Color2 = Color.Orange;
            TransparencyKey = Color.FromArgb(30, 30, 30);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private KryptonLabel kryptonLabel1;
    }
}
