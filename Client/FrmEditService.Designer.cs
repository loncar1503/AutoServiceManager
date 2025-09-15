using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace Client
{
    partial class FrmEditService
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
            kryptonLabel6 = new KryptonLabel();
            txtNote = new KryptonTextBox();
            kryptonButton2 = new KryptonButton();
            kryptonButton1 = new KryptonButton();
            kryptonLabel5 = new KryptonLabel();
            txtDescription = new KryptonTextBox();
            btnDodajUslugu = new KryptonButton();
            dgvUsluge = new KryptonDataGridView();
            kryptonLabel4 = new KryptonLabel();
            lblJob = new KryptonLabel();
            cmbUsluga = new KryptonComboBox();
            kryptonLabel3 = new KryptonLabel();
            txtUkupnaCena = new KryptonTextBox();
            kryptonLabel2 = new KryptonLabel();
            dtpDatum = new KryptonDateTimePicker();
            kryptonLabel1 = new KryptonLabel();
            lblMechanic = new KryptonLabel();
            cmbVozilo = new KryptonComboBox();
            cmbMehanicar = new KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsluge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbUsluga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbVozilo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbMehanicar).BeginInit();
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
            // kryptonLabel6
            // 
            kryptonLabel6.Anchor = AnchorStyles.None;
            kryptonLabel6.Location = new Point(519, 147);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(53, 24);
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.Orange;
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel6.TabIndex = 49;
            kryptonLabel6.Values.Text = "Note";
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.None;
            txtNote.Location = new Point(498, 177);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(308, 50);
            txtNote.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtNote.StateCommon.Border.Color1 = Color.WhiteSmoke;
            txtNote.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtNote.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtNote.StateCommon.Border.Rounding = 12;
            txtNote.StateCommon.Border.Width = 1;
            txtNote.StateCommon.Content.Font = new Font("Poppins", 9.2f, FontStyle.Regular);
            txtNote.StateCommon.Content.Padding = new Padding(8, 10, 8, 10);
            txtNote.TabIndex = 48;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Anchor = AnchorStyles.None;
            kryptonButton2.Location = new Point(894, 593);
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
            kryptonButton2.TabIndex = 47;
            kryptonButton2.Values.Text = "Delete job";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.None;
            kryptonButton1.Location = new Point(443, 670);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(210, 106, 8);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(210, 85, 2);
            kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.OverrideDefault.Border.Rounding = 20;
            kryptonButton1.OverrideDefault.Border.Width = 1;
            kryptonButton1.PaletteMode = PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(204, 68);
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
            kryptonButton1.TabIndex = 46;
            kryptonButton1.Values.Text = "Save changes";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Anchor = AnchorStyles.None;
            kryptonLabel5.Location = new Point(65, 395);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(184, 24);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.Orange;
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel5.TabIndex = 45;
            kryptonLabel5.Values.Text = "Service description:";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.None;
            txtDescription.Location = new Point(50, 425);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(308, 50);
            txtDescription.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtDescription.StateCommon.Border.Color1 = Color.WhiteSmoke;
            txtDescription.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtDescription.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtDescription.StateCommon.Border.Rounding = 12;
            txtDescription.StateCommon.Border.Width = 1;
            txtDescription.StateCommon.Content.Font = new Font("Poppins", 9.2f, FontStyle.Regular);

            txtDescription.StateCommon.Content.Padding = new Padding(8, 10, 8, 10);
            txtDescription.TabIndex = 44;
            // 
            // btnDodajUslugu
            // 
            btnDodajUslugu.Anchor = AnchorStyles.None;
            btnDodajUslugu.Location = new Point(879, 188);
            btnDodajUslugu.Name = "btnDodajUslugu";
            btnDodajUslugu.OverrideDefault.Back.Color1 = Color.FromArgb(210, 106, 8);
            btnDodajUslugu.OverrideDefault.Back.Color2 = Color.FromArgb(210, 85, 2);
            btnDodajUslugu.OverrideDefault.Back.ColorAngle = 45F;
            btnDodajUslugu.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnDodajUslugu.OverrideDefault.Border.Rounding = 20;
            btnDodajUslugu.OverrideDefault.Border.Width = 1;
            btnDodajUslugu.PaletteMode = PaletteMode.ProfessionalSystem;
            btnDodajUslugu.Size = new Size(142, 39);
            btnDodajUslugu.StateCommon.Back.Color1 = Color.FromArgb(210, 106, 8);
            btnDodajUslugu.StateCommon.Back.Color2 = Color.FromArgb(210, 85, 2);
            btnDodajUslugu.StateCommon.Back.ColorAngle = 45F;
            btnDodajUslugu.StateCommon.Border.Color1 = Color.FromArgb(210, 106, 8);
            btnDodajUslugu.StateCommon.Border.Color2 = Color.FromArgb(210, 85, 2);
            btnDodajUslugu.StateCommon.Border.ColorAngle = 45F;
            btnDodajUslugu.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnDodajUslugu.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnDodajUslugu.StateCommon.Border.Rounding = 20;
            btnDodajUslugu.StateCommon.Border.Width = 1;
            btnDodajUslugu.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            btnDodajUslugu.StateCommon.Content.ShortText.Font = new Font("Franklin Gothic Heavy", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajUslugu.StatePressed.Back.Color1 = Color.FromArgb(166, 98, 4);
            btnDodajUslugu.StatePressed.Back.Color2 = Color.FromArgb(87, 51, 2);
            btnDodajUslugu.StatePressed.Back.ColorAngle = 45F;
            btnDodajUslugu.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnDodajUslugu.StatePressed.Border.Rounding = 20;
            btnDodajUslugu.StatePressed.Border.Width = 1;
            btnDodajUslugu.StateTracking.Back.Color1 = Color.FromArgb(192, 64, 0);
            btnDodajUslugu.StateTracking.Back.Color2 = Color.FromArgb(210, 85, 2);
            btnDodajUslugu.StateTracking.Back.ColorAngle = 45F;
            btnDodajUslugu.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnDodajUslugu.StateTracking.Border.Rounding = 20;
            btnDodajUslugu.StateTracking.Border.Width = 1;
            btnDodajUslugu.TabIndex = 43;
            btnDodajUslugu.Values.Text = "Add job";
            btnDodajUslugu.Click += btnDodajUslugu_Click;
            // 
            // dgvUsluge
            // 
            dgvUsluge.Anchor = AnchorStyles.None;
            dgvUsluge.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsluge.Location = new Point(498, 262);
            dgvUsluge.Name = "dgvUsluge";
            dgvUsluge.RowHeadersWidth = 51;
            dgvUsluge.Size = new Size(734, 300);
            dgvUsluge.StateCommon.Background.Color1 = Color.FromArgb(40, 40, 40);
            dgvUsluge.StateCommon.Background.Color2 = Color.FromArgb(255, 128, 0);
            dgvUsluge.StateCommon.Background.ColorAngle = 45F;
            dgvUsluge.StateCommon.Background.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            dgvUsluge.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            dgvUsluge.StateCommon.DataCell.Back.Color1 = Color.FromArgb(40, 40, 40);
            dgvUsluge.StateCommon.DataCell.Back.Color2 = Color.FromArgb(40, 40, 40);
            dgvUsluge.StateCommon.DataCell.Content.Color1 = Color.WhiteSmoke;
            dgvUsluge.StateCommon.DataCell.Content.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvUsluge.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(40, 40, 40);
            dgvUsluge.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(255, 128, 0);
            dgvUsluge.StateCommon.HeaderColumn.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            dgvUsluge.StateCommon.HeaderColumn.Content.Color1 = Color.FromArgb(255, 128, 0);
            dgvUsluge.StateCommon.HeaderColumn.Content.Font = new Font("Poppins SemiBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvUsluge.StateCommon.HeaderRow.Back.Color1 = Color.FromArgb(40, 40, 40);
            dgvUsluge.StateCommon.HeaderRow.Border.Color1 = Color.FromArgb(255, 128, 0);
            dgvUsluge.StateCommon.HeaderRow.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            dgvUsluge.StateCommon.HeaderRow.Content.Color1 = Color.WhiteSmoke;
            dgvUsluge.TabIndex = 31;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.None;
            kryptonLabel4.Location = new Point(498, 20);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(149, 30);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.Orange;
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 42;
            kryptonLabel4.Values.Text = "Service item";
            // 
            // lblJob
            // 
            lblJob.Anchor = AnchorStyles.None;
            lblJob.Location = new Point(519, 68);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(44, 24);
            lblJob.StateCommon.ShortText.Color1 = Color.Orange;
            lblJob.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJob.TabIndex = 41;
            lblJob.Values.Text = "Job";
            // 
            // cmbUsluga
            // 
            cmbUsluga.Anchor = AnchorStyles.None;
            cmbUsluga.DropDownWidth = 281;
            cmbUsluga.Location = new Point(498, 102);
            cmbUsluga.Name = "cmbUsluga";
            cmbUsluga.Size = new Size(281, 50);
            cmbUsluga.StateCommon.ComboBox.Content.Padding = new Padding(5, 10, 5, 10);
            cmbUsluga.StateCommon.ComboBox.Content.Font = new Font("Poppins", 9.2f, FontStyle.Regular);
            cmbUsluga.StateCommon.ComboBox.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbUsluga.StateCommon.ComboBox.Border.Rounding = 20;
            cmbUsluga.StateCommon.ComboBox.Border.Width = 1;
            cmbUsluga.StateCommon.Item.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbUsluga.StateCommon.Item.Border.Rounding = 20;
            cmbUsluga.StateCommon.Item.Border.Width = 1;
            cmbUsluga.TabIndex = 40;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.None;
            kryptonLabel3.Location = new Point(50, 593);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(109, 24);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.Orange;
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 39;
            kryptonLabel3.Values.Text = "Total price:";
            // 
            // txtUkupnaCena
            // 
            txtUkupnaCena.Anchor = AnchorStyles.None;
            txtUkupnaCena.Location = new Point(50, 637);
            txtUkupnaCena.Name = "txtUkupnaCena";
            txtUkupnaCena.Size = new Size(308, 35);
            txtUkupnaCena.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtUkupnaCena.StateCommon.Border.Color1 = Color.WhiteSmoke;
            txtUkupnaCena.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtUkupnaCena.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtUkupnaCena.StateCommon.Border.Rounding = 12;
            txtUkupnaCena.StateCommon.Border.Width = 1;
            txtUkupnaCena.StateCommon.Content.Color1 = Color.DimGray;
            txtUkupnaCena.TabIndex = 38;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.None;
            kryptonLabel2.Location = new Point(65, 262);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(58, 24);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.Orange;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 36;
            kryptonLabel2.Values.Text = "Date:";
            // 
            // dtpDatum
            // 
            dtpDatum.Anchor = AnchorStyles.None;
            dtpDatum.CustomFormat = "dd.MM.yyyy";
            dtpDatum.Format = DateTimePickerFormat.Custom;
            dtpDatum.Location = new Point(50, 292);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(281, 43);
            dtpDatum.StateActive.Back.Color1 = Color.White;
            dtpDatum.StateCommon.Back.Color1 = Color.White;
            dtpDatum.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            dtpDatum.StateCommon.Border.Rounding = 20;
            dtpDatum.StateCommon.Border.Width = 1;
            dtpDatum.StateCommon.Content.Color1 = Color.Black;
            dtpDatum.StateCommon.Content.Font = new Font("Poppins", 9F);
            dtpDatum.StateCommon.Content.Padding = new Padding(8, 6, 8, 6);
            dtpDatum.TabIndex = 37;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Anchor = AnchorStyles.None;
            kryptonLabel1.Location = new Point(65, 147);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(81, 24);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.Orange;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 35;
            kryptonLabel1.Values.Text = "Vehicle:";
            // 
            // lblMechanic
            // 
            lblMechanic.Anchor = AnchorStyles.None;
            lblMechanic.Location = new Point(65, 36);
            lblMechanic.Name = "lblMechanic";
            lblMechanic.Size = new Size(100, 24);
            lblMechanic.StateCommon.ShortText.Color1 = Color.Orange;
            lblMechanic.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMechanic.TabIndex = 34;
            lblMechanic.Values.Text = "Mechanic:";
            // 
            // cmbVozilo
            // 
            cmbVozilo.Anchor = AnchorStyles.None;
            cmbVozilo.DropDownWidth = 281;
            cmbVozilo.Location = new Point(50, 177);
            cmbVozilo.Name = "cmbVozilo";
            cmbVozilo.Size = new Size(281, 50);
            cmbVozilo.StateCommon.ComboBox.Content.Padding = new Padding(5, 10, 5, 10);
            cmbVozilo.StateCommon.ComboBox.Content.Font = new Font("Poppins", 9.2f, FontStyle.Regular);
            cmbVozilo.StateCommon.ComboBox.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbVozilo.StateCommon.ComboBox.Border.Rounding = 20;
            cmbVozilo.StateCommon.ComboBox.Border.Width = 1;
            cmbVozilo.StateCommon.Item.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbVozilo.StateCommon.Item.Border.Rounding = 20;
            cmbVozilo.StateCommon.Item.Border.Width = 1;
            cmbVozilo.TabIndex = 33;
            // 
            // cmbMehanicar
            // 
            cmbMehanicar.Anchor = AnchorStyles.None;
            cmbMehanicar.DropDownWidth = 281;
            cmbMehanicar.Location = new Point(50, 66);
            cmbMehanicar.Name = "cmbMehanicar";
            cmbMehanicar.Size = new Size(281, 50);
            cmbMehanicar.StateCommon.ComboBox.Content.Padding = new Padding(5, 10, 5, 10);
            cmbMehanicar.StateCommon.ComboBox.Content.Font = new Font("Poppins", 9.2f, FontStyle.Regular);
            cmbMehanicar.StateCommon.ComboBox.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbMehanicar.StateCommon.ComboBox.Border.Rounding = 20;
            cmbMehanicar.StateCommon.ComboBox.Border.Width = 1;
            cmbMehanicar.StateCommon.Item.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbMehanicar.StateCommon.Item.Border.Rounding = 20;
            cmbMehanicar.StateCommon.Item.Border.Width = 1;
            cmbMehanicar.TabIndex = 32;
            // 
            // FrmEditService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1262, 802);
            Controls.Add(kryptonLabel6);
            Controls.Add(txtNote);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonLabel5);
            Controls.Add(txtDescription);
            Controls.Add(btnDodajUslugu);
            Controls.Add(dgvUsluge);
            Controls.Add(kryptonLabel4);
            Controls.Add(lblJob);
            Controls.Add(cmbUsluga);
            Controls.Add(kryptonLabel3);
            Controls.Add(txtUkupnaCena);
            Controls.Add(kryptonLabel2);
            Controls.Add(dtpDatum);
            Controls.Add(kryptonLabel1);
            Controls.Add(lblMechanic);
            Controls.Add(cmbVozilo);
            Controls.Add(cmbMehanicar);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(2, 3, 2, 3);
            Name = "FrmEditService";
            Palette = kryptonPalette1;
            PaletteMode = PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.FromArgb(30, 30, 30);
            ((System.ComponentModel.ISupportInitialize)dgvUsluge).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbUsluga).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbVozilo).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbMehanicar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public KryptonLabel kryptonLabel6;
        public KryptonTextBox txtNote;
        public KryptonButton kryptonButton2;
        public KryptonButton kryptonButton1;
        public KryptonLabel kryptonLabel5;
        public KryptonTextBox txtDescription;
        public KryptonButton btnDodajUslugu;
        public KryptonDataGridView dgvUsluge;
        public KryptonLabel kryptonLabel4;
        public KryptonLabel lblJob;
        public KryptonComboBox cmbUsluga;
        public KryptonLabel kryptonLabel3;
        public KryptonTextBox txtUkupnaCena;
        public KryptonLabel kryptonLabel2;
        public KryptonDateTimePicker dtpDatum;
        public KryptonLabel kryptonLabel1;
        public KryptonLabel lblMechanic;
        public KryptonComboBox cmbVozilo;
        public KryptonComboBox cmbMehanicar;
    }
}