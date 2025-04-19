namespace WarehouseProject2.Reports
{
    partial class ReportPage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            toTypeLabel = new Label();
            fromTypeLabel = new Label();
            orderIdLabel = new Label();
            orderTypeLabel = new Label();
            toNameLabel = new Label();
            fromNameLabel = new Label();
            orderDateLabel = new Label();
            reportGrid = new DataGridView();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)reportGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 13);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Order ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 41);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Order Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 89);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "From:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 129);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 3;
            label4.Text = "To:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 172);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 4;
            label5.Text = "Date:";
            // 
            // toTypeLabel
            // 
            toTypeLabel.AutoSize = true;
            toTypeLabel.Location = new Point(110, 129);
            toTypeLabel.Name = "toTypeLabel";
            toTypeLabel.Size = new Size(56, 20);
            toTypeLabel.TabIndex = 6;
            toTypeLabel.Text = "to type";
            // 
            // fromTypeLabel
            // 
            fromTypeLabel.AutoSize = true;
            fromTypeLabel.Location = new Point(110, 89);
            fromTypeLabel.Name = "fromTypeLabel";
            fromTypeLabel.Size = new Size(74, 20);
            fromTypeLabel.TabIndex = 5;
            fromTypeLabel.Text = "from type";
            // 
            // orderIdLabel
            // 
            orderIdLabel.AutoSize = true;
            orderIdLabel.Location = new Point(294, 13);
            orderIdLabel.Name = "orderIdLabel";
            orderIdLabel.Size = new Size(24, 20);
            orderIdLabel.TabIndex = 7;
            orderIdLabel.Text = "ID";
            // 
            // orderTypeLabel
            // 
            orderTypeLabel.AutoSize = true;
            orderTypeLabel.Location = new Point(295, 41);
            orderTypeLabel.Name = "orderTypeLabel";
            orderTypeLabel.Size = new Size(38, 20);
            orderTypeLabel.TabIndex = 8;
            orderTypeLabel.Text = "type";
            // 
            // toNameLabel
            // 
            toNameLabel.AutoSize = true;
            toNameLabel.Location = new Point(366, 129);
            toNameLabel.Name = "toNameLabel";
            toNameLabel.Size = new Size(64, 20);
            toNameLabel.TabIndex = 12;
            toNameLabel.Text = "to name";
            // 
            // fromNameLabel
            // 
            fromNameLabel.AutoSize = true;
            fromNameLabel.Location = new Point(366, 89);
            fromNameLabel.Name = "fromNameLabel";
            fromNameLabel.Size = new Size(82, 20);
            fromNameLabel.TabIndex = 11;
            fromNameLabel.Text = "from name";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new Point(110, 172);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new Size(83, 20);
            orderDateLabel.TabIndex = 13;
            orderDateLabel.Text = "Order Date";
            // 
            // reportGrid
            // 
            reportGrid.BackgroundColor = SystemColors.ButtonHighlight;
            reportGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportGrid.GridColor = Color.WhiteSmoke;
            reportGrid.Location = new Point(3, 216);
            reportGrid.Name = "reportGrid";
            reportGrid.RowHeadersWidth = 51;
            reportGrid.Size = new Size(562, 388);
            reportGrid.TabIndex = 14;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(224, 628);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 15;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // ReportPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 669);
            Controls.Add(exitBtn);
            Controls.Add(reportGrid);
            Controls.Add(orderDateLabel);
            Controls.Add(toNameLabel);
            Controls.Add(fromNameLabel);
            Controls.Add(orderTypeLabel);
            Controls.Add(orderIdLabel);
            Controls.Add(toTypeLabel);
            Controls.Add(fromTypeLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReportPage";
            Text = "ReportPage";
            ((System.ComponentModel.ISupportInitialize)reportGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label toTypeLabel;
        private Label fromTypeLabel;
        private Label orderIdLabel;
        private Label orderTypeLabel;
        private Label toNameLabel;
        private Label fromNameLabel;
        private Label orderDateLabel;
        private DataGridView reportGrid;
        private Button exitBtn;
    }
}