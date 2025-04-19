namespace WarehouseProject2.Dialogs
{
    partial class OrderInDialog
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
            allProductsList = new ListBox();
            selectedProductsGrid = new DataGridView();
            quantityTextbox = new TextBox();
            label1 = new Label();
            insertBtn = new Button();
            newProductBtn = new Button();
            supplierCombobox = new ComboBox();
            deleteBtn = new Button();
            cancelBtn = new Button();
            okBtn = new Button();
            label2 = new Label();
            expiryDatePicker = new DateTimePicker();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)selectedProductsGrid).BeginInit();
            SuspendLayout();
            // 
            // allProductsList
            // 
            allProductsList.FormattingEnabled = true;
            allProductsList.Location = new Point(0, 0);
            allProductsList.Name = "allProductsList";
            allProductsList.Size = new Size(192, 284);
            allProductsList.TabIndex = 0;
            allProductsList.SelectedIndexChanged += allProductsList_SelectedIndexChanged;
            // 
            // selectedProductsGrid
            // 
            selectedProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedProductsGrid.Location = new Point(379, 0);
            selectedProductsGrid.Name = "selectedProductsGrid";
            selectedProductsGrid.RowHeadersWidth = 51;
            selectedProductsGrid.Size = new Size(420, 284);
            selectedProductsGrid.TabIndex = 1;
            selectedProductsGrid.CellContentClick += selectedProductsGrid_CellContentClick;
            // 
            // quantityTextbox
            // 
            quantityTextbox.Location = new Point(224, 68);
            quantityTextbox.Name = "quantityTextbox";
            quantityTextbox.Size = new Size(125, 27);
            quantityTextbox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 45);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 3;
            label1.Text = "Quantity";
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(240, 117);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(94, 29);
            insertBtn.TabIndex = 4;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // newProductBtn
            // 
            newProductBtn.Location = new Point(431, 304);
            newProductBtn.Name = "newProductBtn";
            newProductBtn.Size = new Size(152, 29);
            newProductBtn.TabIndex = 5;
            newProductBtn.Text = "Add New Product";
            newProductBtn.UseVisualStyleBackColor = true;
            newProductBtn.Click += newProductBtn_Click;
            // 
            // supplierCombobox
            // 
            supplierCombobox.FormattingEnabled = true;
            supplierCombobox.Location = new Point(41, 338);
            supplierCombobox.Name = "supplierCombobox";
            supplierCombobox.Size = new Size(268, 28);
            supplierCombobox.TabIndex = 6;
            supplierCombobox.SelectedIndexChanged += supplierCombobox_SelectedIndexChanged;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(621, 304);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(151, 29);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(418, 399);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(260, 399);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 8;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 315);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 10;
            label2.Text = "Supplier";
            // 
            // expiryDatePicker
            // 
            expiryDatePicker.Location = new Point(522, 354);
            expiryDatePicker.Name = "expiryDatePicker";
            expiryDatePicker.Size = new Size(250, 27);
            expiryDatePicker.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(431, 359);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 12;
            label3.Text = "Expiry Date";
            // 
            // OrderInDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(expiryDatePicker);
            Controls.Add(label2);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(deleteBtn);
            Controls.Add(supplierCombobox);
            Controls.Add(newProductBtn);
            Controls.Add(insertBtn);
            Controls.Add(label1);
            Controls.Add(quantityTextbox);
            Controls.Add(selectedProductsGrid);
            Controls.Add(allProductsList);
            Name = "OrderInDialog";
            Text = "OrderDialog";
            ((System.ComponentModel.ISupportInitialize)selectedProductsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox allProductsList;
        private DataGridView selectedProductsGrid;
        private TextBox quantityTextbox;
        private Label label1;
        private Button insertBtn;
        private Button newProductBtn;
        private ComboBox supplierCombobox;
        private Button deleteBtn;
        private Button cancelBtn;
        private Button okBtn;
        private Label label2;
        private DateTimePicker expiryDatePicker;
        private Label label3;
    }
}