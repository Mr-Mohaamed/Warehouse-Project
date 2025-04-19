namespace WarehouseProject2.Dialogs
{
    partial class newProductDialog
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
            nameTextBox = new TextBox();
            codeTextBox = new TextBox();
            quantityTextbox = new TextBox();
            typeCombobox = new ComboBox();
            okBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cancelBtn = new Button();
            kilogramRadio = new RadioButton();
            gramRadio = new RadioButton();
            literRadio = new RadioButton();
            milleLiterMU = new RadioButton();
            expiryDatePicker = new DateTimePicker();
            label5 = new Label();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(36, 44);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(279, 27);
            nameTextBox.TabIndex = 0;
            // 
            // codeTextBox
            // 
            codeTextBox.Location = new Point(36, 97);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(279, 27);
            codeTextBox.TabIndex = 1;
            // 
            // quantityTextbox
            // 
            quantityTextbox.Location = new Point(36, 154);
            quantityTextbox.Name = "quantityTextbox";
            quantityTextbox.Size = new Size(279, 27);
            quantityTextbox.TabIndex = 2;
            // 
            // typeCombobox
            // 
            typeCombobox.FormattingEnabled = true;
            typeCombobox.Location = new Point(36, 207);
            typeCombobox.Name = "typeCombobox";
            typeCombobox.Size = new Size(279, 28);
            typeCombobox.TabIndex = 3;
            typeCombobox.SelectedIndexChanged += typeCombobox_SelectedIndexChanged;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(36, 409);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(98, 29);
            okBtn.TabIndex = 4;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 21);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 74);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 6;
            label2.Text = "Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 184);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 7;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 131);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 8;
            label4.Text = "Quantity";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(219, 409);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(96, 29);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // kilogramRadio
            // 
            kilogramRadio.AutoSize = true;
            kilogramRadio.Location = new Point(36, 336);
            kilogramRadio.Name = "kilogramRadio";
            kilogramRadio.Size = new Size(91, 24);
            kilogramRadio.TabIndex = 10;
            kilogramRadio.TabStop = true;
            kilogramRadio.Tag = "solidMU";
            kilogramRadio.Text = "Kilogram";
            kilogramRadio.UseVisualStyleBackColor = true;
            kilogramRadio.CheckedChanged += kilogramRadio_CheckedChanged;
            // 
            // gramRadio
            // 
            gramRadio.AutoSize = true;
            gramRadio.Location = new Point(36, 366);
            gramRadio.Name = "gramRadio";
            gramRadio.Size = new Size(66, 24);
            gramRadio.TabIndex = 11;
            gramRadio.TabStop = true;
            gramRadio.Tag = "solidMU";
            gramRadio.Text = "Gram";
            gramRadio.UseVisualStyleBackColor = true;
            gramRadio.CheckedChanged += gramRadio_CheckedChanged;
            // 
            // literRadio
            // 
            literRadio.AutoSize = true;
            literRadio.Enabled = false;
            literRadio.Location = new Point(219, 336);
            literRadio.Name = "literRadio";
            literRadio.Size = new Size(59, 24);
            literRadio.TabIndex = 12;
            literRadio.TabStop = true;
            literRadio.Tag = "liquidMU";
            literRadio.Text = "Liter";
            literRadio.UseVisualStyleBackColor = true;
            literRadio.CheckedChanged += literRadio_CheckedChanged;
            // 
            // milleLiterMU
            // 
            milleLiterMU.AutoSize = true;
            milleLiterMU.Enabled = false;
            milleLiterMU.Location = new Point(219, 366);
            milleLiterMU.Name = "milleLiterMU";
            milleLiterMU.Size = new Size(96, 24);
            milleLiterMU.TabIndex = 13;
            milleLiterMU.TabStop = true;
            milleLiterMU.Tag = "liquidMU";
            milleLiterMU.Text = "Mille Liter";
            milleLiterMU.UseVisualStyleBackColor = true;
            milleLiterMU.CheckedChanged += milleLiterMU_CheckedChanged;
            // 
            // expiryDatePicker
            // 
            expiryDatePicker.Location = new Point(36, 271);
            expiryDatePicker.Name = "expiryDatePicker";
            expiryDatePicker.Size = new Size(279, 27);
            expiryDatePicker.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 248);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 15;
            label5.Text = "Expiry Date";
            // 
            // newProductDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 450);
            Controls.Add(label5);
            Controls.Add(expiryDatePicker);
            Controls.Add(milleLiterMU);
            Controls.Add(literRadio);
            Controls.Add(gramRadio);
            Controls.Add(kilogramRadio);
            Controls.Add(cancelBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(okBtn);
            Controls.Add(typeCombobox);
            Controls.Add(quantityTextbox);
            Controls.Add(codeTextBox);
            Controls.Add(nameTextBox);
            Name = "newProductDialog";
            Text = "newProductDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox codeTextBox;
        private TextBox quantityTextbox;
        private ComboBox typeCombobox;
        private Button okBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button cancelBtn;
        private RadioButton kilogramRadio;
        private RadioButton gramRadio;
        private RadioButton literRadio;
        private RadioButton milleLiterMU;
        private DateTimePicker expiryDatePicker;
        private Label label5;
    }
}