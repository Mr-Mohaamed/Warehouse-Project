namespace WarehouseProject2.Dialogs
{
    partial class WarehouseDialog
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
            allProductsGrid = new DataGridView();
            label2 = new Label();
            cancelBtn = new Button();
            okBtn = new Button();
            deleteBtn = new Button();
            warehouseCombobox = new ComboBox();
            insertBtn = new Button();
            label1 = new Label();
            quantityTextbox = new TextBox();
            selectedProductsGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)allProductsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedProductsGrid).BeginInit();
            SuspendLayout();
            // 
            // allProductsGrid
            // 
            allProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allProductsGrid.EditMode = DataGridViewEditMode.EditOnF2;
            allProductsGrid.Location = new Point(-3, 11);
            allProductsGrid.Name = "allProductsGrid";
            allProductsGrid.RowHeadersWidth = 51;
            allProductsGrid.Size = new Size(330, 284);
            allProductsGrid.TabIndex = 32;
            allProductsGrid.CellContentClick += allProductsGrid_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 326);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 31;
            label2.Text = "Warehouse";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(423, 410);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 30;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(293, 410);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 29;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(560, 317);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(151, 29);
            deleteBtn.TabIndex = 28;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // warehouseCombobox
            // 
            warehouseCombobox.FormattingEnabled = true;
            warehouseCombobox.Location = new Point(46, 349);
            warehouseCombobox.Name = "warehouseCombobox";
            warehouseCombobox.Size = new Size(268, 28);
            warehouseCombobox.TabIndex = 27;
            warehouseCombobox.SelectedIndexChanged += warehouseCombobox_SelectedIndexChanged;
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(354, 142);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(94, 29);
            insertBtn.TabIndex = 26;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 70);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 25;
            label1.Text = "Quantity";
            // 
            // quantityTextbox
            // 
            quantityTextbox.Location = new Point(338, 93);
            quantityTextbox.Name = "quantityTextbox";
            quantityTextbox.Size = new Size(125, 27);
            quantityTextbox.TabIndex = 24;
            // 
            // selectedProductsGrid
            // 
            selectedProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedProductsGrid.Location = new Point(474, 11);
            selectedProductsGrid.Name = "selectedProductsGrid";
            selectedProductsGrid.RowHeadersWidth = 51;
            selectedProductsGrid.Size = new Size(330, 284);
            selectedProductsGrid.TabIndex = 23;
            selectedProductsGrid.CellContentClick += selectedProductsGrid_CellContentClick;
            // 
            // WarehouseDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(allProductsGrid);
            Controls.Add(label2);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(deleteBtn);
            Controls.Add(warehouseCombobox);
            Controls.Add(insertBtn);
            Controls.Add(label1);
            Controls.Add(quantityTextbox);
            Controls.Add(selectedProductsGrid);
            Name = "WarehouseDialog";
            Text = "WarehouseDialog";
            ((System.ComponentModel.ISupportInitialize)allProductsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectedProductsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView allProductsGrid;
        private Label label2;
        private Button cancelBtn;
        private Button okBtn;
        private Button deleteBtn;
        private ComboBox warehouseCombobox;
        private Button insertBtn;
        private Label label1;
        private TextBox quantityTextbox;
        private DataGridView selectedProductsGrid;
    }
}