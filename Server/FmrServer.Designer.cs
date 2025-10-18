namespace Server
{
    partial class Form1
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
            lblStatus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            btnStart = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            btnStop = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(421, 201);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(149, 24);
            lblStatus.TabIndex = 2;
            lblStatus.Values.Text = "Server nije pokrenut";
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.None;
            btnStart.Location = new Point(131, 86);
            btnStart.Name = "btnStart";
            btnStart.OverrideDefault.Back.Color1 = Color.FromArgb(210, 106, 8);
            btnStart.OverrideDefault.Back.Color2 = Color.FromArgb(210, 85, 2);
            btnStart.OverrideDefault.Back.ColorAngle = 45F;
            btnStart.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnStart.OverrideDefault.Border.Rounding = 20;
            btnStart.OverrideDefault.Border.Width = 1;
            btnStart.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnStart.Size = new Size(204, 79);
            btnStart.StateCommon.Back.Color1 = Color.FromArgb(210, 106, 8);
            btnStart.StateCommon.Back.Color2 = Color.FromArgb(210, 85, 2);
            btnStart.StateCommon.Back.ColorAngle = 45F;
            btnStart.StateCommon.Border.Color1 = Color.FromArgb(210, 106, 8);
            btnStart.StateCommon.Border.Color2 = Color.FromArgb(210, 85, 2);
            btnStart.StateCommon.Border.ColorAngle = 45F;
            btnStart.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnStart.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnStart.StateCommon.Border.Rounding = 20;
            btnStart.StateCommon.Border.Width = 1;
            btnStart.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            btnStart.StateCommon.Content.ShortText.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.StatePressed.Back.Color1 = Color.FromArgb(166, 98, 4);
            btnStart.StatePressed.Back.Color2 = Color.FromArgb(87, 51, 2);
            btnStart.StatePressed.Back.ColorAngle = 45F;
            btnStart.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnStart.StatePressed.Border.Rounding = 20;
            btnStart.StatePressed.Border.Width = 1;
            btnStart.StateTracking.Back.Color1 = Color.FromArgb(192, 64, 0);
            btnStart.StateTracking.Back.Color2 = Color.FromArgb(210, 85, 2);
            btnStart.StateTracking.Back.ColorAngle = 45F;
            btnStart.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnStart.StateTracking.Border.Rounding = 20;
            btnStart.StateTracking.Border.Width = 1;
            btnStart.TabIndex = 47;
            btnStart.Values.Text = "START";
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.None;
            btnStop.Location = new Point(131, 235);
            btnStop.Name = "btnStop";
            btnStop.OverrideDefault.Back.Color1 = Color.FromArgb(210, 106, 8);
            btnStop.OverrideDefault.Back.Color2 = Color.FromArgb(210, 85, 2);
            btnStop.OverrideDefault.Back.ColorAngle = 45F;
            btnStop.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnStop.OverrideDefault.Border.Rounding = 20;
            btnStop.OverrideDefault.Border.Width = 1;
            btnStop.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnStop.Size = new Size(204, 79);
            btnStop.StateCommon.Back.Color1 = Color.FromArgb(210, 106, 8);
            btnStop.StateCommon.Back.Color2 = Color.FromArgb(210, 85, 2);
            btnStop.StateCommon.Back.ColorAngle = 45F;
            btnStop.StateCommon.Border.Color1 = Color.FromArgb(210, 106, 8);
            btnStop.StateCommon.Border.Color2 = Color.FromArgb(210, 85, 2);
            btnStop.StateCommon.Border.ColorAngle = 45F;
            btnStop.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnStop.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnStop.StateCommon.Border.Rounding = 20;
            btnStop.StateCommon.Border.Width = 1;
            btnStop.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            btnStop.StateCommon.Content.ShortText.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStop.StatePressed.Back.Color1 = Color.FromArgb(166, 98, 4);
            btnStop.StatePressed.Back.Color2 = Color.FromArgb(87, 51, 2);
            btnStop.StatePressed.Back.ColorAngle = 45F;
            btnStop.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnStop.StatePressed.Border.Rounding = 20;
            btnStop.StatePressed.Border.Width = 1;
            btnStop.StateTracking.Back.Color1 = Color.FromArgb(192, 64, 0);
            btnStop.StateTracking.Back.Color2 = Color.FromArgb(210, 85, 2);
            btnStop.StateTracking.Back.ColorAngle = 45F;
            btnStop.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnStop.StateTracking.Border.Rounding = 20;
            btnStop.StateTracking.Border.Width = 1;
            btnStop.TabIndex = 48;
            btnStop.Values.Text = "STOP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblStatus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblStatus;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnStart;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnStop;
    }
}
