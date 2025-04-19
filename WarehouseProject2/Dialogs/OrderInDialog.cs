using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WarehouseProject2.Common;
using WarehouseProject2.Entities;
using Type = WarehouseProject2.Entities.Type;

namespace WarehouseProject2.Dialogs
{

    public partial class OrderInDialog : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<NewItem> NewProducts { get; set; } = new List<NewItem>();
        public class NewItem
        {
            public Product Product { get; set; }
            public int Quantity { get; set; }
            public DateTime ExpiryDate { get; set; }
            //public MeasuringUnit MU { get; set; }
            public MeasuringUnits MU { get; set; }
            //public NewItem(Product product, int quantity, MeasuringUnit mu, DateTime expiryDate)
            public NewItem(Product product, int quantity, MeasuringUnits mu, DateTime expiryDate)
            {
                Product = product;
                Quantity = quantity;
                MU = mu;
                ExpiryDate = expiryDate;
            }
        }
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
        public Product AllProductsSelectedItem { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DisplayItem SelectedProductsSelectedItem { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public List<DisplayItem> SelectedProducts { get; set; } = new List<DisplayItem>();
        public OrderInDialog(Warehouse selectedWarehouse)
        {
            InitializeComponent();

            // Set Selected Warehouse
            SelectedWarehouse = selectedWarehouse;

            // Put All Suppliers in combobox
            supplierCombobox.DataSource = db.Suppliers.ToList();
            supplierCombobox.DisplayMember = "S_Name";
            supplierCombobox.ValueMember = "S_ID";

            // Put All Products in list
            allProductsList.DataSource = db.Product_Warehouses
                .Where(pw => pw.W_ID == selectedWarehouse.W_ID)
                .Include(pw => pw.Product)
                .Select(pw => pw.Product)
                .GroupBy(p=> p.P_ID)
                .Select(p => p.First())
                .ToList();
            allProductsList.DisplayMember = "P_Name";
            allProductsList.ValueMember = "P_ID";
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            var found = SelectedProducts.FirstOrDefault(p => p.Product.P_ID == AllProductsSelectedItem.P_ID);
            if (AllProductsSelectedItem != null)
            {
                if (found != null)
                {
                    found.Quantity += int.Parse(quantityTextbox.Text);
                    selectedProductsGrid.DataSource = null;
                    selectedProductsGrid.DataSource = SelectedProducts;
                    selectedProductsGrid.Columns["Product"].Visible = false;
                }
                else
                {
                    if (int.TryParse(quantityTextbox.Text, out int quantity))
                    {
                        DateTime expiryDate = expiryDatePicker.Value;
                        SelectedProducts.Add(new DisplayItem(AllProductsSelectedItem, quantity, expiryDate));
                        selectedProductsGrid.DataSource = null;
                        selectedProductsGrid.DataSource = SelectedProducts;
                        selectedProductsGrid.Columns["Product"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Quantity must be a number");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product");
            }

        }

        private void newProductBtn_Click(object sender, EventArgs e)
        {
            //var newProductDialog = new newProductDialog(SelectedProducts);
            var newProductDialog = new newProductDialog();
            var productDialog = newProductDialog.ShowDialog();
            if (productDialog == DialogResult.OK)
            {
                NewProducts.Add(new NewItem(newProductDialog.Product, newProductDialog.Quantity, newProductDialog.MUSelected, newProductDialog.date));
                SelectedProducts.Add(new DisplayItem(newProductDialog.Product, newProductDialog.Quantity, newProductDialog.date));
                selectedProductsGrid.DataSource = null;
                selectedProductsGrid.DataSource = SelectedProducts;
                selectedProductsGrid.Columns["Product"].Visible = false;
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (SelectedProductsSelectedItem != null && SelectedProductsSelectedItem.GetType() == typeof(DisplayItem))
            {
                SelectedProducts.Remove(SelectedProductsSelectedItem);
                // if removed item is new product remove it from NewProducts
                if (SelectedProductsSelectedItem.New)
                {
                    NewProducts.RemoveAll(np => np.Product.P_Name == SelectedProductsSelectedItem.Name);
                }
                selectedProductsGrid.DataSource = null;
                selectedProductsGrid.DataSource = SelectedProducts;
                selectedProductsGrid.Columns["Product"].Visible = false;
            }
            else
            {
                MessageBox.Show("Please select a product");
            }

        }

        private void supplierCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void allProductsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllProductsSelectedItem = (Product)allProductsList.SelectedItem;
        }

        private void selectedProductsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedProductsSelectedItem = (DisplayItem)selectedProductsGrid.CurrentRow.DataBoundItem;
            if (SelectedProductsSelectedItem != null)
            {
                quantityTextbox.Text = SelectedProductsSelectedItem.Quantity.ToString();
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            // make new orderIn
            // put the new orderIn in the database
            // make new orderInItems to the selected products
            // put the new items in the warehouse ( warehouse_Products table ) 
            // put the new items in the orderInItems table
            // put the new orderIn in the orderIn table
            // close the dialog

            OrderIn order = new OrderIn();
            var selectedSupplier = (Supplier)supplierCombobox.SelectedItem;
            order.S_ID = selectedSupplier.S_ID;
            order.W_ID = SelectedWarehouse.W_ID;
            var newOrder = db.OrderIns.Add(order);
            db.SaveChanges();

            foreach (var newProduct in NewProducts)
            {
                Product product = newProduct.Product;
                var newProductEntity = db.Products.Add(product);
                db.SaveChanges();
                //Product_MeasuringUnit product_MeasuringUnit = new Product_MeasuringUnit();
                //product_MeasuringUnit.P_ID = product.P_ID;
                //product_MeasuringUnit.MU_ID = newProduct.MU.MU_ID;
                //db.Product_MeasuringUnits.Add(product_MeasuringUnit);
                db.SaveChanges();
                newProduct.Product.P_ID = newProductEntity.Entity.P_ID;
                // update the P_ID in SelectedProducts
                foreach (var item in SelectedProducts)
                {
                    if (item.Product.P_Name == newProduct.Product.P_Name)
                    {
                        item.Product.P_ID = newProductEntity.Entity.P_ID;
                    }
                }
            }
            foreach (var item in SelectedProducts)
            {
                Product_OrderIn product_OrderIn = new Product_OrderIn();
                product_OrderIn.O_ID = newOrder.Entity.O_ID;
                product_OrderIn.P_ID = item.Product.P_ID;
                product_OrderIn.Quantity = item.Quantity;
                product_OrderIn.ExpiryDate = item.ExpiryDate;
                db.Product_OrderIns.Add(product_OrderIn);
                db.SaveChanges();
                Product_Warehouse product_Warehouse = new();
                product_Warehouse = new Product_Warehouse();
                product_Warehouse.W_ID = SelectedWarehouse.W_ID;
                product_Warehouse.P_ID = item.Product.P_ID;
                product_Warehouse.Quantity = item.Quantity;
                product_Warehouse.ExpiryDate = item.ExpiryDate;
                db.Product_Warehouses.Add(product_Warehouse);
                db.SaveChanges();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
