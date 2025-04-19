namespace WarehouseProject2
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
            ProductsGrid = new DataGridView();
            OrderInBtn = new Button();
            WarehouseComboBox = new ComboBox();
            label1 = new Label();
            OrderOutBtn = new Button();
            NewCustomerBtn = new Button();
            NewSupplierBtn = new Button();
            OrderToWarehouseBtn = new Button();
            reportBtn = new Button();
            newWarehouseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductsGrid).BeginInit();
            SuspendLayout();
            // 
            // ProductsGrid
            // 
            ProductsGrid.BackgroundColor = SystemColors.ControlLightLight;
            ProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsGrid.Location = new Point(88, 87);
            ProductsGrid.Name = "ProductsGrid";
            ProductsGrid.RowHeadersWidth = 51;
            ProductsGrid.Size = new Size(629, 296);
            ProductsGrid.TabIndex = 0;
            ProductsGrid.CellContentClick += ProductsGrid_CellContentClick;
            // 
            // OrderInBtn
            // 
            OrderInBtn.Location = new Point(88, 409);
            OrderInBtn.Name = "OrderInBtn";
            OrderInBtn.Size = new Size(94, 29);
            OrderInBtn.TabIndex = 1;
            OrderInBtn.Text = "Order In";
            OrderInBtn.UseVisualStyleBackColor = true;
            OrderInBtn.Click += OrderInBtn_Click;
            // 
            // WarehouseComboBox
            // 
            WarehouseComboBox.FormattingEnabled = true;
            WarehouseComboBox.Location = new Point(88, 53);
            WarehouseComboBox.Name = "WarehouseComboBox";
            WarehouseComboBox.Size = new Size(468, 28);
            WarehouseComboBox.TabIndex = 2;
            WarehouseComboBox.SelectedIndexChanged += WarehouseComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 30);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "Warehouse";
            // 
            // OrderOutBtn
            // 
            OrderOutBtn.Location = new Point(188, 409);
            OrderOutBtn.Name = "OrderOutBtn";
            OrderOutBtn.Size = new Size(94, 29);
            OrderOutBtn.TabIndex = 4;
            OrderOutBtn.Text = "Order Out";
            OrderOutBtn.UseVisualStyleBackColor = true;
            OrderOutBtn.Click += OrderOutBtn_Click;
            // 
            // NewCustomerBtn
            // 
            NewCustomerBtn.Location = new Point(536, 409);
            NewCustomerBtn.Name = "NewCustomerBtn";
            NewCustomerBtn.Size = new Size(91, 29);
            NewCustomerBtn.TabIndex = 5;
            NewCustomerBtn.Text = "Customer";
            NewCustomerBtn.UseVisualStyleBackColor = true;
            NewCustomerBtn.Click += NewCustomerBtn_Click;
            // 
            // NewSupplierBtn
            // 
            NewSupplierBtn.Location = new Point(633, 409);
            NewSupplierBtn.Name = "NewSupplierBtn";
            NewSupplierBtn.Size = new Size(84, 29);
            NewSupplierBtn.TabIndex = 6;
            NewSupplierBtn.Text = "Supplier";
            NewSupplierBtn.UseVisualStyleBackColor = true;
            NewSupplierBtn.Click += NewSupplierBtn_Click;
            // 
            // OrderToWarehouseBtn
            // 
            OrderToWarehouseBtn.Location = new Point(562, 52);
            OrderToWarehouseBtn.Name = "OrderToWarehouseBtn";
            OrderToWarehouseBtn.Size = new Size(155, 29);
            OrderToWarehouseBtn.TabIndex = 7;
            OrderToWarehouseBtn.Text = "Order To Warehouse";
            OrderToWarehouseBtn.UseVisualStyleBackColor = true;
            OrderToWarehouseBtn.Click += OrderToWarehouseBtn_Click;
            // 
            // reportBtn
            // 
            reportBtn.Location = new Point(353, 409);
            reportBtn.Name = "reportBtn";
            reportBtn.Size = new Size(94, 29);
            reportBtn.TabIndex = 8;
            reportBtn.Text = "Reports";
            reportBtn.UseVisualStyleBackColor = true;
            reportBtn.Click += reportBtn_Click;
            // 
            // newWarehouseBtn
            // 
            newWarehouseBtn.Location = new Point(562, 17);
            newWarehouseBtn.Name = "newWarehouseBtn";
            newWarehouseBtn.Size = new Size(155, 29);
            newWarehouseBtn.TabIndex = 9;
            newWarehouseBtn.Text = "New Warehouse";
            newWarehouseBtn.UseVisualStyleBackColor = true;
            newWarehouseBtn.Click += newWarehouseBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(newWarehouseBtn);
            Controls.Add(reportBtn);
            Controls.Add(OrderToWarehouseBtn);
            Controls.Add(NewSupplierBtn);
            Controls.Add(NewCustomerBtn);
            Controls.Add(OrderOutBtn);
            Controls.Add(label1);
            Controls.Add(WarehouseComboBox);
            Controls.Add(OrderInBtn);
            Controls.Add(ProductsGrid);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ProductsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProductsGrid;
        private Button OrderInBtn;
        private ComboBox WarehouseComboBox;
        private Label label1;
        private Button OrderOutBtn;
        private Button NewCustomerBtn;
        private Button NewSupplierBtn;
        private Button OrderToWarehouseBtn;
        private Button reportBtn;
        private Button newWarehouseBtn;
    }
}
