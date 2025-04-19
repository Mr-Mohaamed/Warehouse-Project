using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WarehouseProject2.Entities;

namespace WarehouseProject2.Reports
{
    public partial class ReportOrder : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Warehouse SelecteWarehouse { get; set; }
        public int orderID = -1;
        public string selectedProductID;
        public string selectedProductName;
        public enum orderType { OrderIn, OrderOut, TransferOrderIn, TransferOrderOut }

        EntityFW db = new EntityFW();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Warehouse SelectedWarehouse { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<displayList> allProducts { get; set; }
        public class displayList
        {
            public string from { get; set; }
            public string to { get; set; }
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public DateTime orderDate { get; set; }
            public DateTime expiryDate { get; set; }
            public orderType type { get; set; }
        }
        public ReportOrder(Warehouse selectedWarehouse)
        {
            InitializeComponent();

            // Orders Tab
            SelectedWarehouse = selectedWarehouse;
            // put order type in type combobox
            ordersTypeCombobox.DataSource = Enum.GetValues(typeof(orderType));
            ordersTypeCombobox.SelectedIndex = 0;
            // Put All Orders in combobox

            var orders = db.OrderIns.Where(o => o.W_ID == SelectedWarehouse.W_ID);

            // Products Tab
            // get all order products from all orders type (OrderIn, OrderOut, TransferOrderIn, TransferOrderOut)
            // getting the source and target and product name and quantity 
            // union all of them and display them in the grid ordered by orderDate

            var allOrderIn = db.OrderIns
                .Where(o => o.W_ID == SelectedWarehouse.W_ID)
                .Include(o => o.Supplier)
                .Include(o => o.OrderProducts)
                .ThenInclude(op => op.Product)
                .ThenInclude(p=> p.Product_Warehouses)
                .ToList();

            var productsInOrderIn = allOrderIn
                .SelectMany(o => o.OrderProducts.Select(op => new displayList
                {
                    from = o.Supplier.S_Name,
                    to = SelectedWarehouse.W_Name,
                    ProductID = op.Product.P_ID,
                    ProductName = op.Product.P_Name,
                    Quantity = op.Quantity,
                    orderDate = o.O_Date,
                    expiryDate = op.ExpiryDate,
                    type = orderType.OrderIn
                })).ToList();

            var allOrderOut = db.OrderOuts
                .Where(o => o.W_ID == SelectedWarehouse.W_ID)
                .Include(o => o.Customer)
                .Include(o => o.OrderProducts)
                .ThenInclude(op => op.Product)
                .ToList();

            var productsInOrderOut = allOrderOut
                .SelectMany(o => o.OrderProducts.Select(op => new displayList
                {
                    from = SelectedWarehouse.W_Name,
                    to = o.Customer.C_Name,
                    ProductID = op.Product.P_ID,
                    ProductName = op.Product.P_Name,
                    Quantity = op.Quantity,
                    orderDate = o.O_Date,
                    expiryDate = op.Product.Product_Warehouses.FirstOrDefault().ExpiryDate,
                    type = orderType.OrderOut
                })).ToList();

            var allTransferOrder = db.TransferOrderIns
                .Where(o => o.TargetWarehouse_ID == SelectedWarehouse.W_ID)
                .Include(o => o.SourceWarehouse)
                .Include(o => o.OrderProducts)
                .ThenInclude(op => op.Product)
                .ToList();

            var productsInTransferOrderIn = allTransferOrder
                .SelectMany(o => o.OrderProducts.Select(op => new displayList
                {
                    from = o.SourceWarehouse.W_Name,
                    to = SelectedWarehouse.W_Name,
                    ProductID = op.Product.P_ID,
                    ProductName = op.Product.P_Name,
                    Quantity = op.Quantity,
                    orderDate = o.O_Date,
                    expiryDate = op.Product.Product_Warehouses.FirstOrDefault().ExpiryDate,
                    type = orderType.TransferOrderIn
                })).ToList();

            var allTransferOrderOut = db.TransferOrderIns
                .Where(o => o.SourceWarehouse_ID == SelectedWarehouse.W_ID)
                .Include(o => o.TargetWarehouse)
                .Include(o => o.OrderProducts)
                .ThenInclude(op => op.Product)
                .ToList();

            var productsInTransferOrderOut = allTransferOrderOut
                .SelectMany(o => o.OrderProducts.Select(op => new displayList
                {
                    from = SelectedWarehouse.W_Name,
                    to = o.TargetWarehouse.W_Name,
                    ProductID = op.Product.P_ID,
                    ProductName = op.Product.P_Name,
                    Quantity = op.Quantity,
                    orderDate = o.O_Date,
                    expiryDate = op.Product.Product_Warehouses.FirstOrDefault().ExpiryDate,
                    type = orderType.TransferOrderOut
                })).ToList();



            allProducts = productsInOrderIn
                .Union(productsInOrderOut)
                .Union(productsInTransferOrderIn)
                .Union(productsInTransferOrderOut)
                .OrderBy(p => p.orderDate)
                .ToList();

            allProductsGrid.DataSource = allProducts;

            // nearly expired products ( all products) ( show all products that have expiry date in the next 30 days + warehouse)
            var nearlyExpiredProducts = db.Product_Warehouses
                .Where(pw => pw.ExpiryDate < DateTime.Now.AddDays(30))
                .Include(pw => pw.Product)
                .Include(pw => pw.Warehouse)
                .ToList();

            var nearlyExpiredProductsList = nearlyExpiredProducts
                .Select(pw => new { pw.Product.P_ID, pw.Product.P_Name, pw.Quantity, pw.ExpiryDate, pw.Warehouse.W_Name })
                .ToList();
            
            nearlyExpiredProductsGrid.DataSource = nearlyExpiredProductsList;
        }



        private void ordersCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void makeReportBtn_Click(object sender, EventArgs e)
        {

        }

        private void singleOrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void allOrdersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            orderID = (int)allOrdersGrid.CurrentRow.Cells[0].Value;
        }


        private void showReportBtn_Click(object sender, EventArgs e)
        {

        }

        private void filterBtn_Click(object sender, EventArgs e)
        {

        }
        private void searchByDate_Click(object sender, EventArgs e)
        {

        }
        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void searchByDateOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ordersTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderID = -1;
            var warehouseName = SelectedWarehouse.W_Name;
            // if order type is OrderIn show orderIn items and if order type is OrderOut show orderOut items and if order type is TransferOrderIn show TransferOrderIn items and if order type is TransferOrderOut show TransferOrderOut items and if order type is All show all items
            var orderType = (orderType)ordersTypeCombobox.SelectedItem;
            switch (orderType)
            {
                case orderType.OrderIn:
                    var allOrderIn = db.OrderIns
                        .Where(o => o.W_ID == SelectedWarehouse.W_ID)
                        .Include(o => o.Supplier)
                        .Include(o => o.OrderProducts)
                        .ThenInclude(op => op.Product)
                        .ToList();
                    // i want to display from and to warehouse name in the grid
                    var displayList = allOrderIn
                        .Select(o => new { o.O_ID, o.Supplier.S_ID, o.Supplier.S_Name, SelectedWarehouse.W_ID, SelectedWarehouse.W_Name, o.O_Date })
                        .ToList();

                    allOrdersGrid.DataSource = null;
                    allOrdersGrid.DataSource = displayList;
                    break;
                case orderType.OrderOut:
                    var allOrderOut = db.OrderOuts
                        .Where(o => o.W_ID == SelectedWarehouse.W_ID)
                        .Include(o => o.Customer)
                        .Include(o => o.OrderProducts)
                        .ThenInclude(op => op.Product)
                        .ToList();
                    // i want to display from and to warehouse name in the grid
                    var displayListOut = allOrderOut
                        .Select(o => new { o.O_ID, SelectedWarehouse.W_ID, SelectedWarehouse.W_Name, o.Customer.C_ID, o.Customer.C_Name, o.O_Date })
                        .ToList();
                    allOrdersGrid.DataSource = null;
                    allOrdersGrid.DataSource = displayListOut;
                    break;
                case orderType.TransferOrderIn:
                    var allTransferOrder = db.TransferOrderOuts
                        .Where(o => o.TargetWarehouse_ID == SelectedWarehouse.W_ID)
                        .Include(o => o.SourceWarehouse)
                        .Include(o => o.OrderProducts)
                        .ThenInclude(op => op.Product)
                        .ToList();
                    // i want to display from and to warehouse name in the grid
                    var displayListTransfer = allTransferOrder
                        .Select(o => new { o.O_ID, o.SourceWarehouse_ID, o.SourceWarehouse.W_Name, SelectedWarehouse.W_ID, warehouseName, o.O_Date })
                        .ToList();
                    allOrdersGrid.DataSource = null;
                    allOrdersGrid.DataSource = displayListTransfer;
                    break;
                case orderType.TransferOrderOut:
                    var allTransferOrderOut = db.TransferOrderOuts
                        .Where(o => o.SourceWarehouse_ID == SelectedWarehouse.W_ID)
                        .Include(o => o.TargetWarehouse)
                        .Include(o => o.OrderProducts)
                        .ThenInclude(op => op.Product)
                        .ToList();
                    // i want to display from and to warehouse name in the grid
                    var displayListTransferOut = allTransferOrderOut
                        .Select(o => new { o.O_ID, SelectedWarehouse.W_ID, warehouseName, o.TargetWarehouse_ID, o.TargetWarehouse.W_Name, o.O_Date })
                        .ToList();
                    allOrdersGrid.DataSource = null;
                    allOrdersGrid.DataSource = displayListTransferOut;
                    break;
            }
        }
        private void fromDatePicker_ValueChanged_1(object sender, EventArgs e)
        {

        }
        private void toDatePicker_ValueChanged_1(object sender, EventArgs e)
        {
            var warehouseName = SelectedWarehouse.W_Name;
            // if order type is OrderIn show orderIn items and if order type is OrderOut show orderOut items and if order type is TransferOrderIn show TransferOrderIn items and if order type is TransferOrderOut show TransferOrderOut items and if order type is All show all items
            var orderType = (orderType)ordersTypeCombobox.SelectedItem;
            switch (orderType)
            {
                case orderType.OrderIn:
                    var allOrderIn = db.OrderIns
                        .Where(o => o.W_ID == SelectedWarehouse.W_ID)
                        .Where(o => o.O_Date < toDatePicker.Value && o.O_Date > fromDatePicker.Value)
                        .Include(o => o.Supplier)
                        .Include(o => o.OrderProducts)
                        .ThenInclude(op => op.Product)
                        .ToList();
                    // i want to display from and to warehouse name in the grid
                    var displayList = allOrderIn
                        .Select(o => new { o.Supplier.S_ID, o.Supplier.S_Name, SelectedWarehouse.W_ID, SelectedWarehouse.W_Name, o.O_Date })
                        .ToList();

                    allOrdersGrid.DataSource = null;
                    allOrdersGrid.DataSource = displayList;
                    break;
                case orderType.OrderOut:
                    var allOrderOut = db.OrderOuts
                        .Where(o => o.W_ID == SelectedWarehouse.W_ID)
                        .Where(o => o.O_Date < toDatePicker.Value && o.O_Date > fromDatePicker.Value)
                        .Include(o => o.Customer)
                        .Include(o => o.OrderProducts)
                        .ThenInclude(op => op.Product)
                        .ToList();
                    // i want to display from and to warehouse name in the grid
                    var displayListOut = allOrderOut
                        .Select(o => new { SelectedWarehouse.W_ID, SelectedWarehouse.W_Name, o.Customer.C_ID, o.Customer.C_Name, o.O_Date })
                        .ToList();
                    allOrdersGrid.DataSource = null;
                    allOrdersGrid.DataSource = displayListOut;
                    break;
                case orderType.TransferOrderIn:
                    var allTransferOrder = db.TransferOrderIns
                        .Where(o => o.TargetWarehouse_ID == SelectedWarehouse.W_ID)
                        .Where(o => o.O_Date < toDatePicker.Value && o.O_Date > fromDatePicker.Value)
                        .Include(o => o.SourceWarehouse)
                        .Include(o => o.OrderProducts)
                        .ThenInclude(op => op.Product)
                        .ToList();
                    // i want to display from and to warehouse name in the grid
                    var displayListTransfer = allTransferOrder
                        .Select(o => new { o.SourceWarehouse_ID, o.SourceWarehouse.W_Name, SelectedWarehouse.W_ID, warehouseName, o.O_Date })
                        .ToList();
                    allOrdersGrid.DataSource = null;
                    allOrdersGrid.DataSource = displayListTransfer;
                    break;
                case orderType.TransferOrderOut:
                    var allTransferOrderOut = db.TransferOrderIns
                        .Where(o => o.SourceWarehouse_ID == SelectedWarehouse.W_ID)
                        .Where(o => o.O_Date < toDatePicker.Value && o.O_Date > fromDatePicker.Value)
                        .Include(o => o.TargetWarehouse)
                        .Include(o => o.OrderProducts)
                        .ThenInclude(op => op.Product)
                        .ToList();
                    // i want to display from and to warehouse name in the grid
                    var displayListTransferOut = allTransferOrderOut
                        .Select(o => new { SelectedWarehouse.W_ID, warehouseName, o.TargetWarehouse_ID, o.TargetWarehouse.W_Name, o.O_Date })
                        .ToList();
                    allOrdersGrid.DataSource = null;
                    allOrdersGrid.DataSource = displayListTransferOut;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var warehouseName = SelectedWarehouse.W_Name;
            // if order type is OrderIn show orderIn items and if order type is OrderOut show orderOut items and if order type is TransferOrderIn show TransferOrderIn items and if order type is TransferOrderOut show TransferOrderOut items and if order type is All show all items
            var orderType = (orderType)ordersTypeCombobox.SelectedItem;
            switch (orderType)
            {
                case orderType.OrderIn:
                    var allOrderIn = db.OrderIns
                        .Where(o => o.W_ID == SelectedWarehouse.W_ID)
                        .Where(o => o.O_Date < toDatePicker.Value && o.O_Date > fromDatePicker.Value)
                        .Include(o => o.Supplier)
                        .Include(o => o.OrderProducts)
                        .ThenInclude(op => op.Product)
                        .ToList();
                    // i want to display from and to warehouse name in the grid
                    var displayList = allOrderIn
                        .Select(o => new
                        {
                            o.O_ID,
                            o.Supplier.S_ID,
                            o.Supplier.S_Name,
                            SelectedWarehouse.W_ID,
                            SelectedWarehouse.W_Name,
                            o.O_Date
                        })
                        .ToList();

                    allOrdersGrid.DataSource = null;
                    allOrdersGrid.DataSource = displayList;
                    break;
                case orderType.OrderOut:
                    var allOrderOut = db.OrderOuts
                        .Where(o => o.W_ID == SelectedWarehouse.W_ID)
                        .Where(o => o.O_Date < toDatePicker.Value && o.O_Date > fromDatePicker.Value)
                        .Include(o => o.Customer)
                        .Include(o => o.OrderProducts)
                        .ThenInclude(op => op.Product)
                        .ToList();
                    // i want to display from and to warehouse name in the grid
                    var displayListOut = allOrderOut
                        .Select(o => new
                        {
                            o.O_ID,
                            SelectedWarehouse.W_ID,
                            SelectedWarehouse.W_Name,
                            o.Customer.C_ID,
                            o.Customer.C_Name,
                            o.O_Date
                        })
                        .ToList();
                    allOrdersGrid.DataSource = null;
                    allOrdersGrid.DataSource = displayListOut;
                    break;
                case orderType.TransferOrderIn:
                    var allTransferOrder = db.TransferOrderIns
                        .Where(o => o.TargetWarehouse_ID == SelectedWarehouse.W_ID)
                        .Where(o => o.O_Date < toDatePicker.Value && o.O_Date > fromDatePicker.Value)
                        .Include(o => o.SourceWarehouse)
                        .Include(o => o.OrderProducts)
                        .ThenInclude(op => op.Product)
                        .ToList();
                    // i want to display from and to warehouse name in the grid
                    var displayListTransfer = allTransferOrder
                        .Select(o => new
                        {
                            o.O_ID,
                            o.SourceWarehouse_ID,
                            o.SourceWarehouse.W_Name,
                            SelectedWarehouse.W_ID,
                            warehouseName,
                            o.O_Date
                        })
                        .ToList();
                    allOrdersGrid.DataSource = null;
                    allOrdersGrid.DataSource = displayListTransfer;
                    break;
                case orderType.TransferOrderOut:
                    var allTransferOrderOut = db.TransferOrderIns
                        .Where(o => o.SourceWarehouse_ID == SelectedWarehouse.W_ID)
                        .Where(o => o.O_Date < toDatePicker.Value && o.O_Date > fromDatePicker.Value)
                        .Include(o => o.TargetWarehouse)
                        .Include(o => o.OrderProducts)
                        .ThenInclude(op => op.Product)
                        .ToList();
                    // i want to display from and to warehouse name in the grid
                    var displayListTransferOut = allTransferOrderOut
                        .Select(o => new
                        {
                            o.O_ID,
                            SelectedWarehouse.W_ID,
                            warehouseName,
                            o.TargetWarehouse_ID,
                            o.TargetWarehouse.W_Name,
                            o.O_Date
                        })
                        .ToList();
                    allOrdersGrid.DataSource = null;
                    allOrdersGrid.DataSource = displayListTransferOut;
                    break;
            }

        }

        private void makeReportBtn_Click_1(object sender, EventArgs e)
        {
            if (orderID == -1)
            {
                MessageBox.Show("Please select an order first");
                return;
            }
            var orderType = (orderType)ordersTypeCombobox.SelectedItem;
            ReportPage reportPage = new ReportPage(orderID, orderType);
            reportPage.ShowDialog();
        }

        private void allProductsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedProductID = allProductsGrid.CurrentRow.Cells[2].Value.ToString();
            selectedProductName = allProductsGrid.CurrentRow.Cells[3].Value.ToString();
            selectedProductLabel.Text = selectedProductName;
        }

        private void selectedProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            allProductsGrid.DataSource = null;
            allProductsGrid.DataSource = allProducts;
            selectedProductLabel.Text = "None";
            selectedProductID = null;
            selectedProductName = null;

        }

        private void filterBtn_Click_1(object sender, EventArgs e)
        {
            List<displayList> filteredProducts = new();
            if (selectedProductID != null)
            {
                filteredProducts = allProducts
                    .Where(p => p.ProductID == int.Parse(selectedProductID))
                    .Where(p => p.orderDate < productDateTo.Value)
                    .Where(p => p.orderDate > productDateFrom.Value)
                    .ToList();
                allProductsGrid.DataSource = null;
                allProductsGrid.DataSource = filteredProducts;

            }
            else
            {
                filteredProducts = allProducts
                    .Where(p => p.orderDate < productDateTo.Value)
                    .Where(p => p.orderDate > productDateFrom.Value)
                    .ToList();
                allProductsGrid.DataSource = null;
                allProductsGrid.DataSource = filteredProducts;

            }
        }

        private void filterByDateBtn_Click(object sender, EventArgs e)
        {
            List<displayList> filteredProducts = new();
            filteredProducts = allProducts
                .Where(p => p.orderDate < productDateTo.Value)
                .Where(p => p.orderDate > productDateFrom.Value)
                .ToList();
            allProductsGrid.DataSource = null;
            allProductsGrid.DataSource = filteredProducts;
        }

        private void filterByProductBtn_Click(object sender, EventArgs e)
        {
            List<displayList> filteredProducts = new();
            if (selectedProductID != null)
            {
                filteredProducts = allProducts
                    .Where(p => p.ProductID == int.Parse(selectedProductID))
                    .ToList();
                allProductsGrid.DataSource = null;
                allProductsGrid.DataSource = filteredProducts;
            }
        }
    }
}
