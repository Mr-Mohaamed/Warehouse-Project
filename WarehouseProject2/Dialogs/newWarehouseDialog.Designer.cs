namespace WarehouseProject2.Dialogs
{
    partial class newWarehouseDialog
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
            nameTextbox = new TextBox();
            okBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            addressTextBox = new TextBox();
            label3 = new Label();
            managerTextbox = new TextBox();
            cancelBtn = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(12, 96);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(282, 27);
            nameTextbox.TabIndex = 0;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(43, 316);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 1;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Address";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(12, 165);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(282, 27);
            addressTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 212);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 6;
            label3.Text = "Manager";
            // 
            // managerTextbox
            // 
            managerTextbox.Location = new Point(12, 235);
            managerTextbox.Name = "managerTextbox";
            managerTextbox.Size = new Size(282, 27);
            managerTextbox.TabIndex = 5;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(165, 316);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 31);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 8;
            label4.Text = "New Warehouse";
            // 
            // newWarehouseDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 375);
            Controls.Add(label4);
            Controls.Add(cancelBtn);
            Controls.Add(label3);
            Controls.Add(managerTextbox);
            Controls.Add(label2);
            Controls.Add(addressTextBox);
            Controls.Add(label1);
            Controls.Add(okBtn);
            Controls.Add(nameTextbox);
            Name = "newWarehouseDialog";
            Text = "newWarehouseDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextbox;
        private Button okBtn;
        private Label label1;
        private Label label2;
        private TextBox addressTextBox;
        private Label label3;
        private TextBox managerTextbox;
        private Button cancelBtn;
        private Label label4;
    }
}