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
            btnStart = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            btnStop = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            lblStatus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(199, 107);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 69);
            btnStart.TabIndex = 0;
            btnStart.Values.Text = "Start";
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(199, 241);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(112, 67);
            btnStop.TabIndex = 1;
            btnStop.Values.Text = "Stop";
            btnStop.Click += btnStop_Click;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(421, 201);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(149, 24);
            lblStatus.TabIndex = 2;
            lblStatus.Values.Text = "Server nije pokrenut";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStart;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStop;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblStatus;
    }
}
