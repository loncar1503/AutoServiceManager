using Client.Properties;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace Client
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            kryptonPalette1 = new KryptonPalette(components);
            pnlMain = new KryptonPanel();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)pnlMain).BeginInit();
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
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.Location = new Point(0, 41);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(832, 437);
            pnlMain.StateCommon.Color1 = Color.FromArgb(40, 40, 40);
            pnlMain.StateCommon.Color2 = Color.FromArgb(255, 128, 0);
            pnlMain.StateCommon.ColorAngle = 45F;
            pnlMain.StateCommon.Image = (Image)resources.GetObject("pnlMain.StateCommon.Image");
            pnlMain.StateCommon.ImageAlign = PaletteRectangleAlign.Local;
            pnlMain.StateCommon.ImageStyle = PaletteImageStyle.Stretch;
            pnlMain.StateNormal.Color1 = Color.FromArgb(40, 40, 40);
            pnlMain.StateNormal.Color2 = Color.Orange;
            pnlMain.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.None;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 9F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(27, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(202, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(844, 480);
            Controls.Add(pnlMain);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 3, 2, 3);
            Name = "FrmMain";
            Palette = kryptonPalette1;
            PaletteMode = PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main page";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pnlMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
     
        private KryptonPanel pnlMain;
        private MenuStrip menuStrip1;
    }
}