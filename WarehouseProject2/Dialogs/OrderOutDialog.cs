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
    public partial class OrderOutDialog : Form
    {
        public class DisplayItem
        {
            public Product Product { get; set; }
            public string Name { get; set; }
            public int Quantity { get; set; }
            public DateTime ExpiryDate { get; set; }
            public bool New { get; set; }
            public MeasuringUnit MeasuringUnit { get; set; }
            public DisplayItem(Product product, int quantity, DateTime expiryDate)
            {
                Product = product;
                Name = product.P_Name;
                Quantity = quantity;
                ExpiryDate = expiryDate;
            }
            public List<Product> NewProducts { get; set; }
        }
        EntityFW db = new EntityFW();
        private Warehouse SelectedWarehouse { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DisplayItem AllProductsSelectedItem { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DisplayItem SelectedProductsSelectedItem { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Customer SelectedCustomer { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<DisplayItem> SelectedProducts { get; set; } = new List<DisplayItem>();
        public OrderOutDialog(Warehouse selectedWarehouse)
        {
            InitializeComponent();
            SelectedWarehouse = selectedWarehouse;
            // Put All Customers in combobox
            customerCombobox.DataSource = db.Customers.ToList();
            customerCombobox.DisplayMember = "C_Name";
            customerCombobox.ValueMember = "C_ID";

            // Put All Products in list
            var Product_WarehouseList = db.Product_Warehouses
                .Where(pw => pw.W_ID == selectedWarehouse.W_ID)
                .Include(pw => pw.Product)
                .ToList();
            var allProducts = Product_WarehouseList.Select(pw => new DisplayItem(pw.Product, pw.Quantity, pw.ExpiryDate)).ToList();

            // show product name and quantity in the allproductgrid
            allProductsGrid.DataSource = allProducts;
            allProductsGrid.Columns["Product"].Visible = false;
            allProductsGrid.Columns["MeasuringUnit"].Visible = false;
            allProductsGrid.Columns["New"].Visible = false;
        }

        private void allProductsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AllProductsSelectedItem = (DisplayItem)allProductsGrid.CurrentRow.DataBoundItem;
        }

        private void selectedProductsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedProductsSelectedItem = (DisplayItem)selectedProductsGrid.CurrentRow.DataBoundItem;
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
            SelectedProducts.Add(new DisplayItem(AllProductsSelectedItem.Product, int.Parse(quantityTextbox.Text), AllProductsSelectedItem.ExpiryDate));
            selectedProductsGrid.DataSource = null;
            selectedProductsGrid.DataSource = SelectedProducts;
            selectedProductsGrid.Columns["Product"].Visible = false;
            selectedProductsGrid.Columns["MeasuringUnit"].Visible = false;
            selectedProductsGrid.Columns["New"].Visible = false;

        }

        private void customerCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCustomer = (Customer)customerCombobox.SelectedItem;

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
            if (SelectedCustomer == null)
            {
                MessageBox.Show("Please select a customer");
                return;
            }
            if (SelectedProducts.Count == 0)
            {
                MessageBox.Show("Please select a product");
                return;
            }
            var order = new OrderOut
            {
                C_ID = SelectedCustomer.C_ID,
                W_ID = SelectedWarehouse.W_ID,
                O_Date = DateTime.Now,
            };
            db.OrderOuts.Add(order);
            db.SaveChanges();
            foreach (var item in SelectedProducts)
            {
                int productID = item.Product.P_ID;
                var productOrderOut = new Product_OrderOut
                {
                    O_ID = order.O_ID,
                    P_ID = productID,
                    Quantity = item.Quantity,
                    ExpiryDate = item.ExpiryDate
                };
                db.Product_OrderOuts.Add(productOrderOut);

                var productWarehouse = db.Product_Warehouses
                    .FirstOrDefault(pw => pw.W_ID == SelectedWarehouse.W_ID && pw.P_ID == productID && pw.ExpiryDate == item.ExpiryDate);
                productWarehouse.Quantity -= item.Quantity;
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
