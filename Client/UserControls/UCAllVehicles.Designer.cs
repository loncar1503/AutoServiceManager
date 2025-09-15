using ComponentFactory.Krypton.Toolkit;

namespace Client.UserControls
{
    partial class UCAllVehicles
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
            dgvAllVehicles = new KryptonDataGridView();
            txtFilter = new KryptonTextBox();
            lblRN = new KryptonLabel();
            kryptonButton1 = new KryptonButton();
            btnEdit = new KryptonButton();
            kryptonButton2 = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)dgvAllVehicles).BeginInit();
            SuspendLayout();
            // 
            // dgvAllVehicles
            // 
            dgvAllVehicles.Anchor = AnchorStyles.None;
            dgvAllVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllVehicles.Location = new Point(308, 139);
            dgvAllVehicles.Name = "dgvAllVehicles";
            dgvAllVehicles.RowHeadersWidth = 51;
            dgvAllVehicles.Size = new Size(853, 438);
            dgvAllVehicles.StateCommon.Background.Color1 = Color.FromArgb(40, 40, 40);
            dgvAllVehicles.StateCommon.Background.Color2 = Color.FromArgb(255, 128, 0);
            dgvAllVehicles.StateCommon.Background.ColorAngle = 45F;
            dgvAllVehicles.StateCommon.Background.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            dgvAllVehicles.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            dgvAllVehicles.StateCommon.DataCell.Back.Color1 = Color.FromArgb(40, 40, 40);
            dgvAllVehicles.StateCommon.DataCell.Back.Color2 = Color.FromArgb(40, 40, 40);
            dgvAllVehicles.StateCommon.DataCell.Content.Color1 = Color.WhiteSmoke;
            dgvAllVehicles.StateCommon.DataCell.Content.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvAllVehicles.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(40, 40, 40);
            dgvAllVehicles.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(255, 128, 0);
            dgvAllVehicles.StateCommon.HeaderColumn.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            dgvAllVehicles.StateCommon.HeaderColumn.Content.Color1 = Color.FromArgb(255, 128, 0);
            dgvAllVehicles.StateCommon.HeaderColumn.Content.Font = new Font("Poppins SemiBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvAllVehicles.StateCommon.HeaderRow.Back.Color1 = Color.FromArgb(40, 40, 40);
            dgvAllVehicles.StateCommon.HeaderRow.Border.Color1 = Color.FromArgb(255, 128, 0);
            dgvAllVehicles.StateCommon.HeaderRow.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            dgvAllVehicles.StateCommon.HeaderRow.Content.Color1 = Color.WhiteSmoke;
            dgvAllVehicles.TabIndex = 0;
            // 
            // txtFilter
            // 
            txtFilter.Anchor = AnchorStyles.None;
            txtFilter.Location = new Point(395, 81);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(278, 35);
            txtFilter.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtFilter.StateCommon.Border.Color1 = Color.WhiteSmoke;
            txtFilter.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtFilter.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtFilter.StateCommon.Border.Rounding = 12;
            txtFilter.StateCommon.Border.Width = 1;
            txtFilter.StateCommon.Content.Color1 = Color.DimGray;
            txtFilter.TabIndex = 3;
            // 
            // lblRN
            // 
            lblRN.Anchor = AnchorStyles.None;
            lblRN.Location = new Point(395, 42);
            lblRN.Name = "lblRN";
            lblRN.Size = new Size(73, 24);
            lblRN.StateCommon.ShortText.Color1 = Color.White;
            lblRN.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRN.TabIndex = 6;
            lblRN.Values.Text = "Search";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.None;
            kryptonButton1.Location = new Point(679, 81);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(210, 106, 8);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.OverrideDefault.Border.Rounding = 20;
            kryptonButton1.OverrideDefault.Border.Width = 1;
            kryptonButton1.PaletteMode = PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(142, 39);
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
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Franklin Gothic Heavy", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            kryptonButton1.TabIndex = 14;
            kryptonButton1.Values.Text = "Search";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.None;
            btnEdit.Location = new Point(669, 606);
            btnEdit.Name = "btnEdit";
            btnEdit.OverrideDefault.Back.Color1 = Color.FromArgb(210, 106, 8);
            btnEdit.OverrideDefault.Back.Color2 = Color.FromArgb(210, 85, 2);
            btnEdit.OverrideDefault.Back.ColorAngle = 45F;
            btnEdit.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnEdit.OverrideDefault.Border.Rounding = 20;
            btnEdit.OverrideDefault.Border.Width = 1;
            btnEdit.PaletteMode = PaletteMode.ProfessionalSystem;
            btnEdit.Size = new Size(142, 39);
            btnEdit.StateCommon.Back.Color1 = Color.FromArgb(210, 106, 8);
            btnEdit.StateCommon.Back.Color2 = Color.FromArgb(210, 85, 2);
            btnEdit.StateCommon.Back.ColorAngle = 45F;
            btnEdit.StateCommon.Border.Color1 = Color.FromArgb(210, 106, 8);
            btnEdit.StateCommon.Border.Color2 = Color.FromArgb(210, 85, 2);
            btnEdit.StateCommon.Border.ColorAngle = 45F;
            btnEdit.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnEdit.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnEdit.StateCommon.Border.Rounding = 20;
            btnEdit.StateCommon.Border.Width = 1;
            btnEdit.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            btnEdit.StateCommon.Content.ShortText.Font = new Font("Franklin Gothic Heavy", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.StatePressed.Back.Color1 = Color.FromArgb(166, 98, 4);
            btnEdit.StatePressed.Back.Color2 = Color.FromArgb(87, 51, 2);
            btnEdit.StatePressed.Back.ColorAngle = 45F;
            btnEdit.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnEdit.StatePressed.Border.Rounding = 20;
            btnEdit.StatePressed.Border.Width = 1;
            btnEdit.StateTracking.Back.Color1 = Color.FromArgb(192, 64, 0);
            btnEdit.StateTracking.Back.Color2 = Color.FromArgb(210, 85, 2);
            btnEdit.StateTracking.Back.ColorAngle = 45F;
            btnEdit.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnEdit.StateTracking.Border.Rounding = 20;
            btnEdit.StateTracking.Border.Width = 1;
            btnEdit.TabIndex = 15;
            btnEdit.Values.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Anchor = AnchorStyles.None;
            kryptonButton2.Location = new Point(853, 606);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.OverrideDefault.Back.Color1 = Color.FromArgb(210, 106, 8);
            kryptonButton2.OverrideDefault.Back.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton2.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton2.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton2.OverrideDefault.Border.Rounding = 20;
            kryptonButton2.OverrideDefault.Border.Width = 1;
            kryptonButton2.PaletteMode = PaletteMode.ProfessionalSystem;
            kryptonButton2.Size = new Size(142, 39);
            kryptonButton2.StateCommon.Back.Color1 = Color.FromArgb(210, 106, 8);
            kryptonButton2.StateCommon.Back.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton2.StateCommon.Back.ColorAngle = 45F;
            kryptonButton2.StateCommon.Border.Color1 = Color.FromArgb(210, 106, 8);
            kryptonButton2.StateCommon.Border.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton2.StateCommon.Border.ColorAngle = 45F;
            kryptonButton2.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton2.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton2.StateCommon.Border.Rounding = 20;
            kryptonButton2.StateCommon.Border.Width = 1;
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            kryptonButton2.StateCommon.Content.ShortText.Font = new Font("Franklin Gothic Heavy", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton2.StatePressed.Back.Color1 = Color.FromArgb(166, 98, 4);
            kryptonButton2.StatePressed.Back.Color2 = Color.FromArgb(87, 51, 2);
            kryptonButton2.StatePressed.Back.ColorAngle = 45F;
            kryptonButton2.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton2.StatePressed.Border.Rounding = 20;
            kryptonButton2.StatePressed.Border.Width = 1;
            kryptonButton2.StateTracking.Back.Color1 = Color.FromArgb(192, 64, 0);
            kryptonButton2.StateTracking.Back.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton2.StateTracking.Back.ColorAngle = 45F;
            kryptonButton2.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton2.StateTracking.Border.Rounding = 20;
            kryptonButton2.StateTracking.Border.Width = 1;
            kryptonButton2.TabIndex = 16;
            kryptonButton2.Values.Text = "Delete";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // UCAllVehicles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            BackgroundImage = Properties.Resources.mechanicBck;
            Controls.Add(kryptonButton2);
            Controls.Add(btnEdit);
            Controls.Add(kryptonButton1);
            Controls.Add(lblRN);
            Controls.Add(txtFilter);
            Controls.Add(dgvAllVehicles);
            Name = "UCAllVehicles";
            Size = new Size(1421, 672);
            ((System.ComponentModel.ISupportInitialize)dgvAllVehicles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public KryptonDataGridView dgvAllVehicles;
        public KryptonTextBox txtFilter;
        public KryptonLabel lblRN;
        private KryptonButton kryptonButton1;
        private KryptonButton btnEdit;
        private KryptonButton kryptonButton2;
    }
}
