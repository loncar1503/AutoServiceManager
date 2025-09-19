using ComponentFactory.Krypton.Toolkit;

namespace Client.UserControls
{
    partial class UCAllServices
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
            dgvAllServices = new KryptonDataGridView();
            kryptonButton1 = new KryptonButton();
            txtCondition = new KryptonTextBox();
            dtpDateFrom = new KryptonDateTimePicker();
            dtpDateTo = new KryptonDateTimePicker();
            btnEdit = new KryptonButton();
            chckAny = new KryptonCheckBox();
            lblJob = new KryptonLabel();
            btnGraph = new KryptonButton();
            kryptonButton2 = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)dgvAllServices).BeginInit();
            SuspendLayout();
            // 
            // dgvAllServices
            // 
            dgvAllServices.Anchor = AnchorStyles.None;
            dgvAllServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllServices.Location = new Point(297, 142);
            dgvAllServices.Name = "dgvAllServices";
            dgvAllServices.RowHeadersWidth = 51;
            dgvAllServices.Size = new Size(959, 401);
            dgvAllServices.StateCommon.Background.Color1 = Color.FromArgb(40, 40, 40);
            dgvAllServices.StateCommon.Background.Color2 = Color.FromArgb(255, 128, 0);
            dgvAllServices.StateCommon.Background.ColorAngle = 45F;
            dgvAllServices.StateCommon.Background.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            dgvAllServices.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            dgvAllServices.StateCommon.DataCell.Back.Color1 = Color.FromArgb(40, 40, 40);
            dgvAllServices.StateCommon.DataCell.Back.Color2 = Color.FromArgb(40, 40, 40);
            dgvAllServices.StateCommon.DataCell.Content.Color1 = Color.WhiteSmoke;
            dgvAllServices.StateCommon.DataCell.Content.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvAllServices.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(40, 40, 40);
            dgvAllServices.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(255, 128, 0);
            dgvAllServices.StateCommon.HeaderColumn.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            dgvAllServices.StateCommon.HeaderColumn.Content.Color1 = Color.FromArgb(255, 128, 0);
            dgvAllServices.StateCommon.HeaderColumn.Content.Font = new Font("Poppins SemiBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvAllServices.StateCommon.HeaderRow.Back.Color1 = Color.FromArgb(40, 40, 40);
            dgvAllServices.StateCommon.HeaderRow.Border.Color1 = Color.FromArgb(255, 128, 0);
            dgvAllServices.StateCommon.HeaderRow.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            dgvAllServices.StateCommon.HeaderRow.Content.Color1 = Color.WhiteSmoke;
            dgvAllServices.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.None;
            kryptonButton1.Location = new Point(62, 152);
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
            kryptonButton1.TabIndex = 17;
            kryptonButton1.Values.Text = "Search";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // txtCondition
            // 
            txtCondition.Anchor = AnchorStyles.None;
            txtCondition.Location = new Point(62, 63);
            txtCondition.Name = "txtCondition";
            txtCondition.Size = new Size(254, 35);
            txtCondition.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtCondition.StateCommon.Border.Color1 = Color.WhiteSmoke;
            txtCondition.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtCondition.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtCondition.StateCommon.Border.Rounding = 12;
            txtCondition.StateCommon.Border.Width = 1;
            txtCondition.StateCommon.Content.Color1 = Color.DimGray;
            txtCondition.TabIndex = 15;
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.Anchor = AnchorStyles.None;
            dtpDateFrom.CustomFormat = "dd.MM.yyyy";
            dtpDateFrom.Format = DateTimePickerFormat.Custom;
            dtpDateFrom.Location = new Point(349, 63);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(145, 43);
            dtpDateFrom.StateActive.Back.Color1 = Color.White;
            dtpDateFrom.StateCommon.Back.Color1 = Color.White;
            dtpDateFrom.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            dtpDateFrom.StateCommon.Border.Rounding = 20;
            dtpDateFrom.StateCommon.Border.Width = 1;
            dtpDateFrom.StateCommon.Content.Color1 = Color.Black;
            dtpDateFrom.StateCommon.Content.Font = new Font("Poppins", 9F);
            dtpDateFrom.StateCommon.Content.Padding = new Padding(8, 6, 8, 6);
            dtpDateFrom.TabIndex = 18;
            // 
            // dtpDateTo
            // 
            dtpDateTo.Anchor = AnchorStyles.None;
            dtpDateTo.CustomFormat = "dd.MM.yyyy";
            dtpDateTo.Format = DateTimePickerFormat.Custom;
            dtpDateTo.Location = new Point(555, 63);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(160, 43);
            dtpDateTo.StateActive.Back.Color1 = Color.White;
            dtpDateTo.StateCommon.Back.Color1 = Color.White;
            dtpDateTo.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            dtpDateTo.StateCommon.Border.Rounding = 20;
            dtpDateTo.StateCommon.Border.Width = 1;
            dtpDateTo.StateCommon.Content.Color1 = Color.Black;
            dtpDateTo.StateCommon.Content.Font = new Font("Poppins", 9F);
            dtpDateTo.StateCommon.Content.Padding = new Padding(8, 6, 8, 6);
            dtpDateTo.TabIndex = 18;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.None;
            btnEdit.Location = new Point(62, 348);
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
            btnEdit.TabIndex = 19;
            btnEdit.Values.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // chckAny
            // 
            chckAny.Anchor = AnchorStyles.None;
            chckAny.Location = new Point(431, 24);
            chckAny.Name = "chckAny";
            chckAny.Size = new Size(54, 25);
            chckAny.StateCommon.ShortText.Color1 = Color.FromArgb(255, 128, 0);
            chckAny.StateCommon.ShortText.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chckAny.TabIndex = 20;
            chckAny.Values.Text = "Any";
            chckAny.CheckedChanged += chckAny_CheckedChanged;
            // 
            // lblJob
            // 
            lblJob.Anchor = AnchorStyles.None;
            lblJob.Location = new Point(349, 25);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(67, 24);
            lblJob.StateCommon.ShortText.Color1 = Color.Orange;
            lblJob.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJob.TabIndex = 42;
            lblJob.Values.Text = "Dates:";
            // 
            // btnGraph
            // 
            btnGraph.Anchor = AnchorStyles.None;
            btnGraph.Location = new Point(62, 477);
            btnGraph.Name = "btnGraph";
            btnGraph.OverrideDefault.Back.Color1 = Color.FromArgb(210, 106, 8);
            btnGraph.OverrideDefault.Back.Color2 = Color.FromArgb(210, 85, 2);
            btnGraph.OverrideDefault.Back.ColorAngle = 45F;
            btnGraph.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnGraph.OverrideDefault.Border.Rounding = 20;
            btnGraph.OverrideDefault.Border.Width = 1;
            btnGraph.PaletteMode = PaletteMode.ProfessionalSystem;
            btnGraph.Size = new Size(142, 39);
            btnGraph.StateCommon.Back.Color1 = Color.FromArgb(210, 106, 8);
            btnGraph.StateCommon.Back.Color2 = Color.FromArgb(210, 85, 2);
            btnGraph.StateCommon.Back.ColorAngle = 45F;
            btnGraph.StateCommon.Border.Color1 = Color.FromArgb(210, 106, 8);
            btnGraph.StateCommon.Border.Color2 = Color.FromArgb(210, 85, 2);
            btnGraph.StateCommon.Border.ColorAngle = 45F;
            btnGraph.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnGraph.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnGraph.StateCommon.Border.Rounding = 20;
            btnGraph.StateCommon.Border.Width = 1;
            btnGraph.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            btnGraph.StateCommon.Content.ShortText.Font = new Font("Franklin Gothic Heavy", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGraph.StatePressed.Back.Color1 = Color.FromArgb(166, 98, 4);
            btnGraph.StatePressed.Back.Color2 = Color.FromArgb(87, 51, 2);
            btnGraph.StatePressed.Back.ColorAngle = 45F;
            btnGraph.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnGraph.StatePressed.Border.Rounding = 20;
            btnGraph.StatePressed.Border.Width = 1;
            btnGraph.StateTracking.Back.Color1 = Color.FromArgb(192, 64, 0);
            btnGraph.StateTracking.Back.Color2 = Color.FromArgb(210, 85, 2);
            btnGraph.StateTracking.Back.ColorAngle = 45F;
            btnGraph.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnGraph.StateTracking.Border.Rounding = 20;
            btnGraph.StateTracking.Border.Width = 1;
            btnGraph.TabIndex = 43;
            btnGraph.Values.Text = "View graph";
            btnGraph.Click += btnGraph_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Anchor = AnchorStyles.None;
            kryptonButton2.Location = new Point(36, 583);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.OverrideDefault.Back.Color1 = Color.FromArgb(210, 106, 8);
            kryptonButton2.OverrideDefault.Back.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton2.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton2.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton2.OverrideDefault.Border.Rounding = 20;
            kryptonButton2.OverrideDefault.Border.Width = 1;
            kryptonButton2.PaletteMode = PaletteMode.ProfessionalSystem;
            kryptonButton2.Size = new Size(206, 43);
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
            kryptonButton2.TabIndex = 44;
            kryptonButton2.Values.Text = "Create service report";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // UCAllServices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(kryptonButton2);
            Controls.Add(btnGraph);
            Controls.Add(lblJob);
            Controls.Add(chckAny);
            Controls.Add(btnEdit);
            Controls.Add(dtpDateTo);
            Controls.Add(dtpDateFrom);
            Controls.Add(kryptonButton1);
            Controls.Add(txtCondition);
            Controls.Add(dgvAllServices);
            Name = "UCAllServices";
            Size = new Size(1359, 767);
            ((System.ComponentModel.ISupportInitialize)dgvAllServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvAllServices;
        public ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCondition;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDateFrom;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDateTo;
        private KryptonButton btnEdit;
        public KryptonCheckBox chckAny;
        public KryptonLabel lblJob;
        private KryptonButton btnGraph;
        private KryptonButton kryptonButton2;
    }
}
