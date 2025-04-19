using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using WarehouseProject2.Dialogs;
using WarehouseProject2.Entities;

namespace WarehouseProject2
{
    public partial class Form1 : Form
    {
        EntityFW db = new EntityFW();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Warehouse SelectedWarehouse { get; set; }
        public Form1()
        {
            InitializeComponent();

            //create database by ensure created
            db.Database.EnsureCreated();

            WarehouseComboBox.DataSource = db.Warehouses.ToList();
            WarehouseComboBox.DisplayMember = "W_Name";
            WarehouseComboBox.ValueMember = "W_ID";
        }

        private void OrderToWarehouseBtn_Click(object sender, EventArgs e)
        {
            var warehouseDialog = new WarehouseDialog(SelectedWarehouse);
            warehouseDialog.ShowDialog();
        }

        private void WarehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Put All Warehouses in combobox


            //WarehouseComboBox.SelectedItem = db.Warehouses.LastOrDefault();
            SelectedWarehouse = (Warehouse)WarehouseComboBox.SelectedItem;
            // Put All Products in list with quantity in productWarehouse table and show only product name and quantity in the grid

            var Product_WarehouseList = db.Product_Warehouses
                .Where(pw => pw.W_ID == SelectedWarehouse.W_ID)
                .Include(pw => pw.Product)
                .ToList();

            //var allProducts = Product_WarehouseList.Select(pw => new OrderInDialog.DisplayItem(pw.Product, pw.Quantity)).ToList();
            var allProducts = Product_WarehouseList
                .GroupBy(pw => pw.P_ID)
                .Select(pw => new
                {
                    P_ID = pw.Key,
                    P_Name = pw.First().Product.P_Name,
                    P_Code = pw.First().Product.P_Code,
                    TotalQuantity = pw.Sum(pw => pw.Quantity)
                }).ToList();

            ProductsGrid.DataSource = allProducts;
        }

        private void ProductsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void OrderInBtn_Click(object sender, EventArgs e)
        {
            var orderInDialog = new OrderInDialog(SelectedWarehouse);
            var dialog = orderInDialog.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                //WarehouseComboBox.SelectedItem = db.Warehouses.LastOrDefault();
                SelectedWarehouse = (Warehouse)WarehouseComboBox.SelectedItem;
                // Put All Products in list with quantity in productWarehouse table and show only product name and quantity in the grid

                var Product_WarehouseList = db.Product_Warehouses
                    .Where(pw => pw.W_ID == SelectedWarehouse.W_ID)
                    .Include(pw => pw.Product)
                    .ToList();

                //var allProducts = Product_WarehouseList.Select(pw => new OrderInDialog.DisplayItem(pw.Product, pw.Quantity)).ToList();
                var allProducts = Product_WarehouseList
                    .GroupBy(pw => pw.P_ID)
                    .Select(pw => new
                    {
                        P_ID = pw.Key,
                        P_Name = pw.First().Product.P_Name,
                        P_Code = pw.First().Product.P_Code,
                        TotalQuantity = pw.Sum(pw => pw.Quantity)
                    }).ToList();

                ProductsGrid.DataSource = null;
                ProductsGrid.DataSource = allProducts;

            }
        }

        private void OrderOutBtn_Click(object sender, EventArgs e)
        {
            var orderOutDialog = new OrderOutDialog(SelectedWarehouse);
            var dialog = orderOutDialog.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                //WarehouseComboBox.SelectedItem = db.Warehouses.LastOrDefault();
                SelectedWarehouse = (Warehouse)WarehouseComboBox.SelectedItem;
                // Put All Products in list with quantity in productWarehouse table and show only product name and quantity in the grid

                var Product_WarehouseList = db.Product_Warehouses
                    .Where(pw => pw.W_ID == SelectedWarehouse.W_ID)
                    .Include(pw => pw.Product)
                    .ToList();

                //var allProducts = Product_WarehouseList.Select(pw => new OrderInDialog.DisplayItem(pw.Product, pw.Quantity)).ToList();
                var allProducts = Product_WarehouseList
                    .GroupBy(pw => pw.P_ID)
                    .Select(pw => new
                    {
                        P_ID = pw.Key,
                        P_Name = pw.First().Product.P_Name,
                        P_Code = pw.First().Product.P_Code,
                        TotalQuantity = pw.Sum(pw => pw.Quantity)
                    }).ToList();

                ProductsGrid.DataSource = null;
                ProductsGrid.DataSource = allProducts;

            }
        }

        private void NewCustomerBtn_Click(object sender, EventArgs e)
        {
            var customerDialog = new CustomerDialog();
            customerDialog.ShowDialog();
        }

        private void NewSupplierBtn_Click(object sender, EventArgs e)
        {
            var supplierDialog = new SupplierDialog();
            supplierDialog.ShowDialog();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            var reportOrder = new Reports.ReportOrder(SelectedWarehouse);
            reportOrder.ShowDialog();
        }

        private void newWarehouseBtn_Click(object sender, EventArgs e)
        {
            var newWarehouseDialog = new newWarehouseDialog();
            var dialog = newWarehouseDialog.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                WarehouseComboBox.DataSource = db.Warehouses.ToList();
                WarehouseComboBox.DisplayMember = "W_Name";
                WarehouseComboBox.ValueMember = "W_ID";

                //WarehouseComboBox.SelectedItem = db.Warehouses.LastOrDefault();
                SelectedWarehouse = (Warehouse)WarehouseComboBox.SelectedItem;
                // Put All Products in list with quantity in productWarehouse table and show only product name and quantity in the grid

                var Product_WarehouseList = db.Product_Warehouses
                    .Where(pw => pw.W_ID == SelectedWarehouse.W_ID)
                    .Include(pw => pw.Product)
                    .ToList();

                //var allProducts = Product_WarehouseList.Select(pw => new OrderInDialog.DisplayItem(pw.Product, pw.Quantity)).ToList();
                var allProducts = Product_WarehouseList
                    .GroupBy(pw => pw.P_ID)
                    .Select(pw => new
                    {
                        P_ID = pw.Key,
                        P_Name = pw.First().Product.P_Name,
                        P_Code = pw.First().Product.P_Code,
                        TotalQuantity = pw.Sum(pw => pw.Quantity)
                    }).ToList();

                ProductsGrid.DataSource = null;
                ProductsGrid.DataSource = allProducts;

            }
        }
    }
}
