using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseProject2.Entities;

namespace WarehouseProject2.Dialogs
{
    public partial class WarehouseDialog : Form
    {
        EntityFW db = new EntityFW();

        private Warehouse SourceWarehouse { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public OrderInDialog.DisplayItem AllProductsSelectedItem { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public OrderInDialog.DisplayItem SelectedProductsSelectedItem { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Warehouse TargetWarehouse { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<OrderInDialog.DisplayItem> SelectedProducts { get; set; } = new List<OrderInDialog.DisplayItem>();
        public WarehouseDialog(Warehouse sourceWarehouse)
        {
            InitializeComponent();
            SourceWarehouse = sourceWarehouse;
            // Put All Customers in combobox
            var warehouses = db.Warehouses.Where(w => w.W_ID != sourceWarehouse.W_ID);
            warehouseCombobox.DataSource = warehouses.ToList();
            warehouseCombobox.DisplayMember = "W_Name";
            warehouseCombobox.ValueMember = "W_ID";

            // Put All Products in list
            var Product_WarehouseList = db.Product_Warehouses
                .Where(pw => pw.W_ID == sourceWarehouse.W_ID)
                .Include(pw => pw.Product)
                .ToList();
            var allProducts = Product_WarehouseList.Select(pw => new OrderInDialog.DisplayItem(pw.Product, pw.Quantity, pw.ExpiryDate)).ToList();

            // show product name and quantity in the allproductgrid
            allProductsGrid.DataSource = allProducts;
            allProductsGrid.Columns["Product"].Visible = false;
            allProductsGrid.Columns["MeasuringUnit"].Visible = false;
            allProductsGrid.Columns["New"].Visible = false;
        }

        private void allProductsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                return;
            }
            MessageBox.Show("selected");
            //disable editing 

            allProductsGrid.ReadOnly = true;


            AllProductsSelectedItem = (OrderInDialog.DisplayItem)allProductsGrid.CurrentRow.DataBoundItem;
        }

        private void selectedProductsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedProductsSelectedItem = (OrderInDialog.DisplayItem)selectedProductsGrid.CurrentRow.DataBoundItem;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (AllProductsSelectedItem == null)
            {
                MessageBox.Show("Please select a product");
                return;
            }
            if (string.IsNullOrEmpty(quantityTextbox.Text))
            {
                MessageBox.Show("Please enter a quantity");
                return;
            }
            if (!int.TryParse(quantityTextbox.Text, out int quantity))
            {
                MessageBox.Show("Quantity must be a number");
                return;
            }

            if (int.Parse(quantityTextbox.Text) > AllProductsSelectedItem.Quantity)
            {
                MessageBox.Show("Quantity must be less than or equal to the available quantity");
                return;
            }
            if (SelectedProducts.Any(p => p.Product.P_ID == AllProductsSelectedItem.Product.P_ID))
            {
                MessageBox.Show("Product already added");
                return;
            }
            SelectedProducts.Add(new OrderInDialog.DisplayItem(AllProductsSelectedItem.Product, int.Parse(quantityTextbox.Text), AllProductsSelectedItem.ExpiryDate));
            selectedProductsGrid.DataSource = null;
            selectedProductsGrid.DataSource = SelectedProducts;
            selectedProductsGrid.Columns["Product"].Visible = false;
            selectedProductsGrid.Columns["MeasuringUnit"].Visible = false;
            selectedProductsGrid.Columns["New"].Visible = false;

        }

        private void warehouseCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TargetWarehouse = (Warehouse)warehouseCombobox.SelectedItem;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (SelectedProductsSelectedItem == null)
            {
                MessageBox.Show("Please select a product");
                return;
            }
            SelectedProducts.Remove(SelectedProductsSelectedItem);
            selectedProductsGrid.DataSource = null;
            selectedProductsGrid.DataSource = SelectedProducts;
            selectedProductsGrid.Columns["Product"].Visible = false;
            selectedProductsGrid.Columns["MeasuringUnit"].Visible = false;
            selectedProductsGrid.Columns["New"].Visible = false;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (SourceWarehouse == null)
            {
                MessageBox.Show("Please select a customer");
                return;
            }
            if (SelectedProducts.Count == 0)
            {
                MessageBox.Show("Please select a product");
                return;
            }
            var order = new TransferOrderOut()
            {
                SourceWarehouse_ID = SourceWarehouse.W_ID,
                TargetWarehouse_ID = TargetWarehouse.W_ID,
                O_Date = DateTime.Now,
            };
            db.TransferOrderOuts.Add(order);
            db.SaveChanges();
            foreach (var item in SelectedProducts)
            {
                int productID = item.Product.P_ID;
                var productTransferOrderOut = new Product_TransferOrderOut()
                {
                    O_ID = order.O_ID,
                    P_ID = productID,
                    Quantity = item.Quantity,
                    ExpiryDate = item.ExpiryDate
                };

                db.Product_TransferOrderOuts.Add(productTransferOrderOut);

                var sourceProductWarehouse = db.Product_Warehouses
                    .FirstOrDefault(pw => pw.W_ID == SourceWarehouse.W_ID && pw.P_ID == productID && pw.ExpiryDate == item.ExpiryDate);
                sourceProductWarehouse.Quantity -= item.Quantity;
                var targetProductWarehouse = new Product_Warehouse()
                {
                    W_ID = TargetWarehouse.W_ID,
                    P_ID = productID,
                    Quantity = item.Quantity,
                    ExpiryDate = item.ExpiryDate
                };
                db.Product_Warehouses.Add(targetProductWarehouse);

                db.SaveChanges();
            }

            MessageBox.Show("Order added successfully");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
