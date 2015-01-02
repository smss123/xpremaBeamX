namespace XpremaBeam
{
    partial class frmAddWhatsAppNumber
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label contactNameLabel;
            System.Windows.Forms.Label whatsAppStatusLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label currentStatusLabel;
            System.Windows.Forms.Label countryIDLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.whatsAppStatusTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.contactNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.currentStatusTextBox = new System.Windows.Forms.ComboBox();
            this.CountryColumnComboBox1 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.saveBtn = new Telerik.WinControls.UI.RadButton();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.whatsAppNumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            contactNameLabel = new System.Windows.Forms.Label();
            whatsAppStatusLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            currentStatusLabel = new System.Windows.Forms.Label();
            countryIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryColumnComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryColumnComboBox1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryColumnComboBox1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whatsAppNumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // contactNameLabel
            // 
            contactNameLabel.AutoSize = true;
            contactNameLabel.Location = new System.Drawing.Point(35, 50);
            contactNameLabel.Name = "contactNameLabel";
            contactNameLabel.Size = new System.Drawing.Size(82, 13);
            contactNameLabel.TabIndex = 1;
            contactNameLabel.Text = "Contact Name:";
            // 
            // whatsAppStatusLabel
            // 
            whatsAppStatusLabel.AutoSize = true;
            whatsAppStatusLabel.Location = new System.Drawing.Point(15, 76);
            whatsAppStatusLabel.Name = "whatsAppStatusLabel";
            whatsAppStatusLabel.Size = new System.Drawing.Size(102, 13);
            whatsAppStatusLabel.TabIndex = 2;
            whatsAppStatusLabel.Text = "Whats App Status:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(30, 24);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(87, 13);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // currentStatusLabel
            // 
            currentStatusLabel.AutoSize = true;
            currentStatusLabel.Location = new System.Drawing.Point(33, 102);
            currentStatusLabel.Name = "currentStatusLabel";
            currentStatusLabel.Size = new System.Drawing.Size(84, 13);
            currentStatusLabel.TabIndex = 8;
            currentStatusLabel.Text = "Current Status:";
            // 
            // countryIDLabel
            // 
            countryIDLabel.AutoSize = true;
            countryIDLabel.Location = new System.Drawing.Point(63, 126);
            countryIDLabel.Name = "countryIDLabel";
            countryIDLabel.Size = new System.Drawing.Size(54, 13);
            countryIDLabel.TabIndex = 10;
            countryIDLabel.Text = "Country :";
            // 
            // whatsAppStatusTextBox
            // 
            this.whatsAppStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.whatsAppNumberBindingSource, "WhatsAppStatus", true));
            this.whatsAppStatusTextBox.Location = new System.Drawing.Point(123, 73);
            this.whatsAppStatusTextBox.Name = "whatsAppStatusTextBox";
            this.whatsAppStatusTextBox.Size = new System.Drawing.Size(199, 20);
            this.whatsAppStatusTextBox.TabIndex = 3;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(123, 22);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(199, 20);
            this.phoneNumberTextBox.TabIndex = 13;
            this.phoneNumberTextBox.ThemeName = "Office2010Silver";
            // 
            // contactNameTextBox
            // 
            this.contactNameTextBox.Location = new System.Drawing.Point(123, 47);
            this.contactNameTextBox.Name = "contactNameTextBox";
            this.contactNameTextBox.Size = new System.Drawing.Size(199, 20);
            this.contactNameTextBox.TabIndex = 14;
            this.contactNameTextBox.ThemeName = "Office2010Silver";
            // 
            // currentStatusTextBox
            // 
            this.currentStatusTextBox.FormattingEnabled = true;
            this.currentStatusTextBox.Location = new System.Drawing.Point(123, 99);
            this.currentStatusTextBox.Name = "currentStatusTextBox";
            this.currentStatusTextBox.Size = new System.Drawing.Size(199, 21);
            this.currentStatusTextBox.TabIndex = 15;
            // 
            // CountryColumnComboBox1
            // 
            this.CountryColumnComboBox1.DataSource = this.countryBindingSource;
            this.CountryColumnComboBox1.DisplayMember = "CountryName";
            // 
            // CountryColumnComboBox1.NestedRadGridView
            // 
            this.CountryColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CountryColumnComboBox1.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.CountryColumnComboBox1.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CountryColumnComboBox1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CountryColumnComboBox1.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CountryColumnComboBox1.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // CountryColumnComboBox1.NestedRadGridView
            // 
            this.CountryColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CountryColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CountryColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CountryColumnComboBox1.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ID";
            gridViewDecimalColumn2.HeaderText = "ID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ID";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "CountryName";
            gridViewTextBoxColumn2.HeaderText = "CountryName";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "CountryName";
            gridViewTextBoxColumn2.Width = 149;
            this.CountryColumnComboBox1.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn2});
            this.CountryColumnComboBox1.EditorControl.MasterTemplate.DataSource = this.countryBindingSource;
            this.CountryColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CountryColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CountryColumnComboBox1.EditorControl.Name = "NestedRadGridView";
            this.CountryColumnComboBox1.EditorControl.ReadOnly = true;
            this.CountryColumnComboBox1.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CountryColumnComboBox1.EditorControl.ShowGroupPanel = false;
            this.CountryColumnComboBox1.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.CountryColumnComboBox1.EditorControl.TabIndex = 0;
            this.CountryColumnComboBox1.Location = new System.Drawing.Point(123, 126);
            this.CountryColumnComboBox1.Name = "CountryColumnComboBox1";
            this.CountryColumnComboBox1.Size = new System.Drawing.Size(199, 20);
            this.CountryColumnComboBox1.TabIndex = 17;
            this.CountryColumnComboBox1.TabStop = false;
            this.CountryColumnComboBox1.ThemeName = "Office2010Silver";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(233, 229);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(131, 41);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "save";
            this.saveBtn.ThemeName = "Office2010Silver";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(XBeamDataLayer.Country);
            // 
            // whatsAppNumberBindingSource
            // 
            this.whatsAppNumberBindingSource.DataSource = typeof(XBeamDataLayer.WhatsAppNumber);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.CountryColumnComboBox1);
            this.radGroupBox1.Controls.Add(this.currentStatusTextBox);
            this.radGroupBox1.Controls.Add(this.contactNameTextBox);
            this.radGroupBox1.Controls.Add(this.phoneNumberTextBox);
            this.radGroupBox1.Controls.Add(countryIDLabel);
            this.radGroupBox1.Controls.Add(currentStatusLabel);
            this.radGroupBox1.Controls.Add(phoneNumberLabel);
            this.radGroupBox1.Controls.Add(whatsAppStatusLabel);
            this.radGroupBox1.Controls.Add(this.whatsAppStatusTextBox);
            this.radGroupBox1.Controls.Add(contactNameLabel);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(11, 46);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(353, 177);
            this.radGroupBox1.TabIndex = 19;
            this.radGroupBox1.ThemeName = "Office2010Silver";
            // 
            // frmAddWhatsAppNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 283);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.saveBtn);
            this.Name = "frmAddWhatsAppNumber";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "Office2010Silver";
            this.Load += new System.EventHandler(this.frmAddWhatsAppNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryColumnComboBox1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryColumnComboBox1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryColumnComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whatsAppNumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource whatsAppNumberBindingSource;
        private System.Windows.Forms.TextBox whatsAppStatusTextBox;
        private Telerik.WinControls.UI.RadTextBox phoneNumberTextBox;
        private Telerik.WinControls.UI.RadTextBox contactNameTextBox;
        private System.Windows.Forms.ComboBox currentStatusTextBox;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CountryColumnComboBox1;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.UI.RadButton saveBtn;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    }
}