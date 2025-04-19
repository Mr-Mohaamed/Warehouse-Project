namespace WarehouseProject2.Reports
{
    partial class ReportOrder
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
            exitBtn = new Button();
            allOrders = new TabPage();
            button1 = new Button();
            makeReportBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            toDatePicker = new DateTimePicker();
            fromDatePicker = new DateTimePicker();
            label4 = new Label();
            ordersTypeCombobox = new ComboBox();
            allOrdersGrid = new DataGridView();
            tabControl1 = new TabControl();
            Products = new TabPage();
            filterByProductBtn = new Button();
            filterByDateBtn = new Button();
            label1 = new Label();
            label6 = new Label();
            productDateTo = new DateTimePicker();
            productDateFrom = new DateTimePicker();
            resetBtn = new Button();
            selectedProductLabel = new Label();
            label5 = new Label();
            filterBtn = new Button();
            allProductsGrid = new DataGridView();
            tabPage1 = new TabPage();
            nearlyExpiredProductsGrid = new DataGridView();
            allOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allOrdersGrid).BeginInit();
            tabControl1.SuspendLayout();
            Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allProductsGrid).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nearlyExpiredProductsGrid).BeginInit();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(694, 444);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 8;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // allOrders
            // 
            allOrders.Controls.Add(button1);
            allOrders.Controls.Add(makeReportBtn);
            allOrders.Controls.Add(label3);
            allOrders.Controls.Add(label2);
            allOrders.Controls.Add(toDatePicker);
            allOrders.Controls.Add(fromDatePicker);
            allOrders.Controls.Add(label4);
            allOrders.Controls.Add(ordersTypeCombobox);
            allOrders.Controls.Add(allOrdersGrid);
            allOrders.Location = new Point(4, 29);
            allOrders.Name = "allOrders";
            allOrders.Padding = new Padding(3);
            allOrders.Size = new Size(792, 404);
            allOrders.TabIndex = 0;
            allOrders.Text = "Orders";
            allOrders.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(606, 357);
            button1.Name = "button1";
            button1.Size = new Size(158, 29);
            button1.TabIndex = 16;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // makeReportBtn
            // 
            makeReportBtn.Location = new Point(606, 290);
            makeReportBtn.Name = "makeReportBtn";
            makeReportBtn.Size = new Size(158, 29);
            makeReportBtn.TabIndex = 15;
            makeReportBtn.Text = "Make Report";
            makeReportBtn.UseVisualStyleBackColor = true;
            makeReportBtn.Click += makeReportBtn_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 376);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 14;
            label3.Text = "To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 336);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 13;
            label2.Text = "From";
            // 
            // toDatePicker
            // 
            toDatePicker.Location = new Point(76, 371);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(250, 27);
            toDatePicker.TabIndex = 12;
            toDatePicker.ValueChanged += toDatePicker_ValueChanged_1;
            // 
            // fromDatePicker
            // 
            fromDatePicker.Location = new Point(76, 331);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(250, 27);
            fromDatePicker.TabIndex = 11;
            fromDatePicker.ValueChanged += fromDatePicker_ValueChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 293);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 6;
            label4.Text = "Type";
            // 
            // ordersTypeCombobox
            // 
            ordersTypeCombobox.FormattingEnabled = true;
            ordersTypeCombobox.Location = new Point(52, 290);
            ordersTypeCombobox.Name = "ordersTypeCombobox";
            ordersTypeCombobox.Size = new Size(450, 28);
            ordersTypeCombobox.TabIndex = 5;
            ordersTypeCombobox.Text = "Type";
            ordersTypeCombobox.SelectedIndexChanged += ordersTypeCombobox_SelectedIndexChanged;
            // 
            // allOrdersGrid
            // 
            allOrdersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allOrdersGrid.Location = new Point(0, 0);
            allOrdersGrid.Name = "allOrdersGrid";
            allOrdersGrid.RowHeadersWidth = 51;
            allOrdersGrid.Size = new Size(792, 281);
            allOrdersGrid.TabIndex = 4;
            allOrdersGrid.CellContentClick += allOrdersGrid_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(allOrders);
            tabControl1.Controls.Add(Products);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 437);
            tabControl1.TabIndex = 4;
            // 
            // Products
            // 
            Products.Controls.Add(filterByProductBtn);
            Products.Controls.Add(filterByDateBtn);
            Products.Controls.Add(label1);
            Products.Controls.Add(label6);
            Products.Controls.Add(productDateTo);
            Products.Controls.Add(productDateFrom);
            Products.Controls.Add(resetBtn);
            Products.Controls.Add(selectedProductLabel);
            Products.Controls.Add(label5);
            Products.Controls.Add(filterBtn);
            Products.Controls.Add(allProductsGrid);
            Products.Location = new Point(4, 29);
            Products.Name = "Products";
            Products.Size = new Size(792, 404);
            Products.TabIndex = 1;
            Products.Text = "Products";
            Products.UseVisualStyleBackColor = true;
            // 
            // filterByProductBtn
            // 
            filterByProductBtn.Location = new Point(584, 313);
            filterByProductBtn.Name = "filterByProductBtn";
            filterByProductBtn.Size = new Size(200, 29);
            filterByProductBtn.TabIndex = 20;
            filterByProductBtn.Text = "Filter By Product";
            filterByProductBtn.UseVisualStyleBackColor = true;
            filterByProductBtn.Click += filterByProductBtn_Click;
            // 
            // filterByDateBtn
            // 
            filterByDateBtn.Location = new Point(584, 265);
            filterByDateBtn.Name = "filterByDateBtn";
            filterByDateBtn.Size = new Size(200, 29);
            filterByDateBtn.TabIndex = 19;
            filterByDateBtn.Text = "Filter By Date";
            filterByDateBtn.UseVisualStyleBackColor = true;
            filterByDateBtn.Click += filterByDateBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 362);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 18;
            label1.Text = "To";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 322);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 17;
            label6.Text = "From";
            // 
            // productDateTo
            // 
            productDateTo.Location = new Point(101, 357);
            productDateTo.Name = "productDateTo";
            productDateTo.Size = new Size(250, 27);
            productDateTo.TabIndex = 16;
            // 
            // productDateFrom
            // 
            productDateFrom.Location = new Point(101, 317);
            productDateFrom.Name = "productDateFrom";
            productDateFrom.Size = new Size(250, 27);
            productDateFrom.TabIndex = 15;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(496, 265);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(68, 29);
            resetBtn.TabIndex = 6;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // selectedProductLabel
            // 
            selectedProductLabel.AutoSize = true;
            selectedProductLabel.Location = new Point(171, 280);
            selectedProductLabel.Name = "selectedProductLabel";
            selectedProductLabel.Size = new Size(121, 20);
            selectedProductLabel.TabIndex = 5;
            selectedProductLabel.Text = "Selected Product";
            selectedProductLabel.Click += selectedProductLabel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 280);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 4;
            label5.Text = "Selected Product:";
            // 
            // filterBtn
            // 
            filterBtn.Location = new Point(584, 358);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(200, 29);
            filterBtn.TabIndex = 3;
            filterBtn.Text = "Filter By Product and date";
            filterBtn.UseVisualStyleBackColor = true;
            filterBtn.Click += filterBtn_Click_1;
            // 
            // allProductsGrid
            // 
            allProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allProductsGrid.Location = new Point(0, 0);
            allProductsGrid.Name = "allProductsGrid";
            allProductsGrid.RowHeadersWidth = 51;
            allProductsGrid.Size = new Size(792, 259);
            allProductsGrid.TabIndex = 0;
            allProductsGrid.CellContentClick += allProductsGrid_CellContentClick;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(nearlyExpiredProductsGrid);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(792, 404);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Nearly Expired";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // nearlyExpiredProductsGrid
            // 
            nearlyExpiredProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nearlyExpiredProductsGrid.Location = new Point(0, 0);
            nearlyExpiredProductsGrid.Name = "nearlyExpiredProductsGrid";
            nearlyExpiredProductsGrid.RowHeadersWidth = 51;
            nearlyExpiredProductsGrid.Size = new Size(792, 404);
            nearlyExpiredProductsGrid.TabIndex = 1;
            // 
            // ReportOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 485);
            Controls.Add(exitBtn);
            Controls.Add(tabControl1);
            Name = "ReportOrder";
            Text = "ReportOrder";
            allOrders.ResumeLayout(false);
            allOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)allOrdersGrid).EndInit();
            tabControl1.ResumeLayout(false);
            Products.ResumeLayout(false);
            Products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)allProductsGrid).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nearlyExpiredProductsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button exitBtn;
        private TabPage allOrders;
        private Button makeReportBtn;
        private Label label3;
        private Label label2;
        private DateTimePicker toDatePicker;
        private DateTimePicker fromDatePicker;
        private Label label4;
        private ComboBox ordersTypeCombobox;
        private DataGridView allOrdersGrid;
        private TabControl tabControl1;
        private Button button1;
        private TabPage Products;
        private Label selectedProductLabel;
        private Label label5;
        private Button filterBtn;
        private DataGridView allProductsGrid;
        private Button resetBtn;
        private Label label1;
        private Label label6;
        private DateTimePicker productDateTo;
        private DateTimePicker productDateFrom;
        private Button filterByProductBtn;
        private Button filterByDateBtn;
        private TabPage tabPage1;
        private DataGridView nearlyExpiredProductsGrid;
    }
}