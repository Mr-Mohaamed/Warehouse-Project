namespace WarehouseProject2.Dialogs
{
    partial class SupplierDialog
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
            label9 = new Label();
            SupplierComboBox = new ComboBox();
            UpdateRadio = new RadioButton();
            NewUserRadio = new RadioButton();
            label6 = new Label();
            SiteTextBox = new TextBox();
            label7 = new Label();
            MobileTextBox = new TextBox();
            label8 = new Label();
            PhoneTextBox = new TextBox();
            label3 = new Label();
            FaxTextBox = new TextBox();
            label4 = new Label();
            EmailTextBox = new TextBox();
            label2 = new Label();
            NameTextBox = new TextBox();
            CancelBtn = new Button();
            OKBtn = new Button();
            label1 = new Label();
            IDTextBox = new TextBox();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(234, 47);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 41;
            label9.Text = "Supplier";
            // 
            // SupplierComboBox
            // 
            SupplierComboBox.Enabled = false;
            SupplierComboBox.FormattingEnabled = true;
            SupplierComboBox.Location = new Point(304, 44);
            SupplierComboBox.Name = "SupplierComboBox";
            SupplierComboBox.Size = new Size(263, 28);
            SupplierComboBox.TabIndex = 40;
            SupplierComboBox.SelectedIndexChanged += SupplierComboBox_SelectedIndexChanged;
            // 
            // UpdateRadio
            // 
            UpdateRadio.AutoSize = true;
            UpdateRadio.Location = new Point(450, 88);
            UpdateRadio.Name = "UpdateRadio";
            UpdateRadio.Size = new Size(112, 24);
            UpdateRadio.TabIndex = 39;
            UpdateRadio.Tag = "type";
            UpdateRadio.Text = "Update User";
            UpdateRadio.UseVisualStyleBackColor = true;
            UpdateRadio.CheckedChanged += UpdateRadio_CheckedChanged;
            // 
            // NewUserRadio
            // 
            NewUserRadio.AutoSize = true;
            NewUserRadio.Checked = true;
            NewUserRadio.Location = new Point(234, 88);
            NewUserRadio.Name = "NewUserRadio";
            NewUserRadio.Size = new Size(93, 24);
            NewUserRadio.TabIndex = 38;
            NewUserRadio.TabStop = true;
            NewUserRadio.Tag = "type";
            NewUserRadio.Text = "New User";
            NewUserRadio.UseVisualStyleBackColor = true;
            NewUserRadio.CheckedChanged += NewUserRadio_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 308);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 37;
            label6.Text = "Site";
            // 
            // SiteTextBox
            // 
            SiteTextBox.Location = new Point(57, 331);
            SiteTextBox.Name = "SiteTextBox";
            SiteTextBox.Size = new Size(686, 27);
            SiteTextBox.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(418, 180);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 35;
            label7.Text = "Mobile";
            // 
            // MobileTextBox
            // 
            MobileTextBox.Location = new Point(418, 203);
            MobileTextBox.Name = "MobileTextBox";
            MobileTextBox.Size = new Size(325, 27);
            MobileTextBox.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(418, 116);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 33;
            label8.Text = "Phone";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(418, 139);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(325, 27);
            PhoneTextBox.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 244);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 31;
            label3.Text = "Fax";
            // 
            // FaxTextBox
            // 
            FaxTextBox.Location = new Point(418, 267);
            FaxTextBox.Name = "FaxTextBox";
            FaxTextBox.Size = new Size(325, 27);
            FaxTextBox.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 244);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 29;
            label4.Text = "Email";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(57, 267);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(325, 27);
            EmailTextBox.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 180);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 27;
            label2.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(57, 203);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(325, 27);
            NameTextBox.TabIndex = 26;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(450, 374);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(94, 29);
            CancelBtn.TabIndex = 25;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // OKBtn
            // 
            OKBtn.Location = new Point(257, 374);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(94, 29);
            OKBtn.TabIndex = 24;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = true;
            OKBtn.Click += OKBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 116);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 23;
            label1.Text = "ID";
            // 
            // IDTextBox
            // 
            IDTextBox.Enabled = false;
            IDTextBox.Location = new Point(57, 139);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(325, 27);
            IDTextBox.TabIndex = 22;
            // 
            // SupplierDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(SupplierComboBox);
            Controls.Add(UpdateRadio);
            Controls.Add(NewUserRadio);
            Controls.Add(label6);
            Controls.Add(SiteTextBox);
            Controls.Add(label7);
            Controls.Add(MobileTextBox);
            Controls.Add(label8);
            Controls.Add(PhoneTextBox);
            Controls.Add(label3);
            Controls.Add(FaxTextBox);
            Controls.Add(label4);
            Controls.Add(EmailTextBox);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            Controls.Add(CancelBtn);
            Controls.Add(OKBtn);
            Controls.Add(label1);
            Controls.Add(IDTextBox);
            Name = "SupplierDialog";
            Text = "SupplierDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private ComboBox SupplierComboBox;
        private RadioButton UpdateRadio;
        private RadioButton NewUserRadio;
        private Label label6;
        private TextBox SiteTextBox;
        private Label label7;
        private TextBox MobileTextBox;
        private Label label8;
        private TextBox PhoneTextBox;
        private Label label3;
        private TextBox FaxTextBox;
        private Label label4;
        private TextBox EmailTextBox;
        private Label label2;
        private TextBox NameTextBox;
        private Button CancelBtn;
        private Button OKBtn;
        private Label label1;
        private TextBox IDTextBox;
    }
}