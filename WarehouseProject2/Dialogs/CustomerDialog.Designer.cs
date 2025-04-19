namespace WarehouseProject2.Dialogs
{
    partial class CustomerDialog
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
            IDTextBox = new TextBox();
            label1 = new Label();
            OKBtn = new Button();
            CancelBtn = new Button();
            label2 = new Label();
            NameTextBox = new TextBox();
            label3 = new Label();
            FaxTextBox = new TextBox();
            label4 = new Label();
            EmailTextBox = new TextBox();
            label6 = new Label();
            SiteTextBox = new TextBox();
            label7 = new Label();
            MobileTextBox = new TextBox();
            label8 = new Label();
            PhoneTextBox = new TextBox();
            NewUserRadio = new RadioButton();
            UpdateRadio = new RadioButton();
            UserComboBox = new ComboBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // IDTextBox
            // 
            IDTextBox.Enabled = false;
            IDTextBox.Location = new Point(53, 104);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(325, 27);
            IDTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 81);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // OKBtn
            // 
            OKBtn.Location = new Point(253, 339);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(94, 29);
            OKBtn.TabIndex = 2;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = true;
            OKBtn.Click += OKBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(446, 339);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(94, 29);
            CancelBtn.TabIndex = 3;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 145);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(53, 168);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(325, 27);
            NameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 209);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 9;
            label3.Text = "Fax";
            // 
            // FaxTextBox
            // 
            FaxTextBox.Location = new Point(414, 232);
            FaxTextBox.Name = "FaxTextBox";
            FaxTextBox.Size = new Size(325, 27);
            FaxTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 209);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(53, 232);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(325, 27);
            EmailTextBox.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 273);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 15;
            label6.Text = "Site";
            // 
            // SiteTextBox
            // 
            SiteTextBox.Location = new Point(53, 296);
            SiteTextBox.Name = "SiteTextBox";
            SiteTextBox.Size = new Size(686, 27);
            SiteTextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 145);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 13;
            label7.Text = "Mobile";
            // 
            // MobileTextBox
            // 
            MobileTextBox.Location = new Point(414, 168);
            MobileTextBox.Name = "MobileTextBox";
            MobileTextBox.Size = new Size(325, 27);
            MobileTextBox.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(414, 81);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 11;
            label8.Text = "Phone";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(414, 104);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(325, 27);
            PhoneTextBox.TabIndex = 10;
            // 
            // NewUserRadio
            // 
            NewUserRadio.AutoSize = true;
            NewUserRadio.Checked = true;
            NewUserRadio.Location = new Point(230, 53);
            NewUserRadio.Name = "NewUserRadio";
            NewUserRadio.Size = new Size(93, 24);
            NewUserRadio.TabIndex = 18;
            NewUserRadio.TabStop = true;
            NewUserRadio.Tag = "type";
            NewUserRadio.Text = "New User";
            NewUserRadio.UseVisualStyleBackColor = true;
            NewUserRadio.CheckedChanged += NewUserRadio_CheckedChanged;
            // 
            // UpdateRadio
            // 
            UpdateRadio.AutoSize = true;
            UpdateRadio.Location = new Point(446, 53);
            UpdateRadio.Name = "UpdateRadio";
            UpdateRadio.Size = new Size(112, 24);
            UpdateRadio.TabIndex = 19;
            UpdateRadio.Tag = "type";
            UpdateRadio.Text = "Update User";
            UpdateRadio.UseVisualStyleBackColor = true;
            UpdateRadio.CheckedChanged += UpdateRadio_CheckedChanged;
            // 
            // UserComboBox
            // 
            UserComboBox.Enabled = false;
            UserComboBox.FormattingEnabled = true;
            UserComboBox.Location = new Point(274, 12);
            UserComboBox.Name = "UserComboBox";
            UserComboBox.Size = new Size(289, 28);
            UserComboBox.TabIndex = 20;
            UserComboBox.SelectedIndexChanged += UserComboBox_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(230, 15);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 21;
            label9.Text = "User";
            // 
            // CustomerDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 380);
            Controls.Add(label9);
            Controls.Add(UserComboBox);
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
            Name = "CustomerDialog";
            Text = "CustomerDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IDTextBox;
        private Label label1;
        private Button OKBtn;
        private Button CancelBtn;
        private Label label2;
        private TextBox NameTextBox;
        private Label label3;
        private TextBox FaxTextBox;
        private Label label4;
        private TextBox EmailTextBox;
        private Label label6;
        private TextBox SiteTextBox;
        private Label label7;
        private TextBox MobileTextBox;
        private Label label8;
        private TextBox PhoneTextBox;
        private RadioButton NewUserRadio;
        private RadioButton UpdateRadio;
        private ComboBox UserComboBox;
        private Label label9;
    }
}