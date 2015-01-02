namespace XpremaBeam.WhatsNumbers
{
    partial class frmGenerateNumber
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
            this.txtStartNumber = new Telerik.WinControls.UI.RadTextBox();
            this.txtStopNumber = new Telerik.WinControls.UI.RadTextBox();
            this.btnStart = new Telerik.WinControls.UI.RadButton();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.CountrycomboBox = new System.Windows.Forms.ComboBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtCountryKey = new Telerik.WinControls.UI.RadTextBox();
            this.btnstop = new Telerik.WinControls.UI.RadButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSave = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStopNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountryKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnstop)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStartNumber
            // 
            this.txtStartNumber.Location = new System.Drawing.Point(151, 21);
            this.txtStartNumber.Name = "txtStartNumber";
            this.txtStartNumber.Size = new System.Drawing.Size(190, 20);
            this.txtStartNumber.TabIndex = 0;
            this.txtStartNumber.ThemeName = "Office2010Silver";
            // 
            // txtStopNumber
            // 
            this.txtStopNumber.Location = new System.Drawing.Point(151, 47);
            this.txtStopNumber.Name = "txtStopNumber";
            this.txtStopNumber.Size = new System.Drawing.Size(190, 20);
            this.txtStopNumber.TabIndex = 1;
            this.txtStopNumber.ThemeName = "Office2010Silver";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(262, 187);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 24);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.ThemeName = "Office2010Silver";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.Location = new System.Drawing.Point(151, 73);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.Size = new System.Drawing.Size(190, 24);
            this.radProgressBar1.TabIndex = 3;
            this.radProgressBar1.ThemeName = "Office2010Silver";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.CountrycomboBox);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.txtCountryKey);
            this.radGroupBox1.Controls.Add(this.radProgressBar1);
            this.radGroupBox1.Controls.Add(this.txtStopNumber);
            this.radGroupBox1.Controls.Add(this.txtStartNumber);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(360, 169);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.ThemeName = "Office2010Silver";
            // 
            // CountrycomboBox
            // 
            this.CountrycomboBox.FormattingEnabled = true;
            this.CountrycomboBox.Location = new System.Drawing.Point(151, 129);
            this.CountrycomboBox.Name = "CountrycomboBox";
            this.CountrycomboBox.Size = new System.Drawing.Size(190, 21);
            this.CountrycomboBox.TabIndex = 6;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(78, 130);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(46, 18);
            this.radLabel4.TabIndex = 5;
            this.radLabel4.Text = "Country";
            this.radLabel4.Click += new System.EventHandler(this.radLabel3_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(78, 103);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(67, 18);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "Country Key";
            this.radLabel3.Click += new System.EventHandler(this.radLabel3_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(71, 47);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(74, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Stop Number";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(71, 21);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(74, 18);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Start Number";
            // 
            // txtCountryKey
            // 
            this.txtCountryKey.Location = new System.Drawing.Point(151, 103);
            this.txtCountryKey.Name = "txtCountryKey";
            this.txtCountryKey.Size = new System.Drawing.Size(190, 20);
            this.txtCountryKey.TabIndex = 4;
            this.txtCountryKey.ThemeName = "Office2010Silver";
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(262, 217);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(110, 24);
            this.btnstop.TabIndex = 5;
            this.btnstop.Text = "Stop";
            this.btnstop.ThemeName = "Office2010Silver";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConnection,
            this.lblSave});
            this.statusStrip1.Location = new System.Drawing.Point(0, 256);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(382, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblConnection
            // 
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(12, 17);
            this.lblConnection.Text = "*";
            // 
            // lblSave
            // 
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(12, 17);
            this.lblSave.Text = "*";
            // 
            // frmGenerateNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 278);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.btnStart);
            this.Name = "frmGenerateNumber";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmGenerateNumber";
            this.ThemeName = "Office2010Silver";
            this.Load += new System.EventHandler(this.frmGenerateNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtStartNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStopNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountryKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnstop)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtStartNumber;
        private Telerik.WinControls.UI.RadTextBox txtStopNumber;
        private Telerik.WinControls.UI.RadButton btnStart;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnstop;
        private Telerik.WinControls.UI.RadTextBox txtCountryKey;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.ComboBox CountrycomboBox;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblConnection;
        private System.Windows.Forms.ToolStripStatusLabel lblSave;
    }
}