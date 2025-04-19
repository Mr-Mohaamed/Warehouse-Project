namespace WarehouseProject2.Dialogs
{
    partial class OrderOutDialog
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
            label2 = new Label();
            cancelBtn = new Button();
            okBtn = new Button();
            deleteBtn = new Button();
            customerCombobox = new ComboBox();
            insertBtn = new Button();
            label1 = new Label();
            quantityTextbox = new TextBox();
            selectedProductsGrid = new DataGridView();
            allProductsGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)selectedProductsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allProductsGrid).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 326);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 21;
            label2.Text = "Customer";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(419, 410);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 20;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(289, 410);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 19;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(556, 317);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(151, 29);
            deleteBtn.TabIndex = 18;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // customerCombobox
            // 
            customerCombobox.FormattingEnabled = true;
            customerCombobox.Location = new Point(42, 349);
            customerCombobox.Name = "customerCombobox";
            customerCombobox.Size = new Size(268, 28);
            customerCombobox.TabIndex = 17;
            customerCombobox.SelectedIndexChanged += customerCombobox_SelectedIndexChanged;
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(350, 142);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(94, 29);
            insertBtn.TabIndex = 15;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 70);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 14;
            label1.Text = "Quantity";
            // 
            // quantityTextbox
            // 
            quantityTextbox.Location = new Point(334, 93);
            quantityTextbox.Name = "quantityTextbox";
            quantityTextbox.Size = new Size(125, 27);
            quantityTextbox.TabIndex = 13;
            // 
            // selectedProductsGrid
            // 
            selectedProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedProductsGrid.Location = new Point(470, 11);
            selectedProductsGrid.Name = "selectedProductsGrid";
            selectedProductsGrid.RowHeadersWidth = 51;
            selectedProductsGrid.Size = new Size(330, 284);
            selectedProductsGrid.TabIndex = 12;
            selectedProductsGrid.CellContentClick += selectedProductsGrid_CellContentClick;
            // 
            // allProductsGrid
            // 
            allProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allProductsGrid.Location = new Point(-7, 11);
            allProductsGrid.Name = "allProductsGrid";
            allProductsGrid.RowHeadersWidth = 51;
            allProductsGrid.Size = new Size(330, 284);
            allProductsGrid.TabIndex = 22;
            allProductsGrid.CellContentClick += allProductsGrid_CellContentClick;
            // 
            // OrderOutDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(allProductsGrid);
            Controls.Add(label2);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(deleteBtn);
            Controls.Add(customerCombobox);
            Controls.Add(insertBtn);
            Controls.Add(label1);
            Controls.Add(quantityTextbox);
            Controls.Add(selectedProductsGrid);
            Name = "OrderOutDialog";
            Text = "OrderOutDialog";
            ((System.ComponentModel.ISupportInitialize)selectedProductsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)allProductsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button cancelBtn;
        private Button okBtn;
        private Button deleteBtn;
        private ComboBox customerCombobox;
        private Button insertBtn;
        private Label label1;
        private TextBox quantityTextbox;
        private DataGridView selectedProductsGrid;
        private DataGridView allProductsGrid;
    }
}