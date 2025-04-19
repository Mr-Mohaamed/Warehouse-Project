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
using static WarehouseProject2.Reports.ReportOrder;

namespace WarehouseProject2.Reports
{
    public partial class ReportPage : Form
    {
        public ReportPage(int orderID, orderType orderType)
        {
            InitializeComponent();
            var db = new EntityFW();

            if (orderType == orderType.OrderIn)
            {
                var order = db.OrderIns
                    .Where(oi => oi.O_ID == orderID)
                    .Include(oi => oi.Supplier)
                    .Include(oi => oi.Warehouse)
                    .Include(oi => oi.OrderProducts)
                    .ThenInclude(op => op.Product)
                    .ThenInclude(p => p.Product_MeasuringUnits)
                    .ThenInclude(pmu => pmu.MeasuringUnit)
                    .FirstOrDefault();

                orderIdLabel.Text = order.O_ID.ToString();
                orderTypeLabel.Text = "Order In";
                orderDateLabel.Text = order.O_Date.ToString();

                fromTypeLabel.Text = "Supplier";
                fromNameLabel.Text = order.Supplier.S_Name;

                toTypeLabel.Text = "Warehouse";
                toNameLabel.Text = order.Warehouse.W_Name;
                // make the column shape of the reportGrid first
                reportGrid.Columns.Add("Product", "Product");
                reportGrid.Columns.Add("Quantity", "Quantity");
                reportGrid.Columns.Add("Product Code", "Product Code");
                reportGrid.Columns.Add("Measuring Unit", "Measuring Unit");

                foreach (var item in order.OrderProducts)
                {
                    reportGrid.Rows.Add(item.Product.P_Name, item.Quantity,item.Product.P_Code, (MeasuringUnits)item.Product.P_MU);
                }
            }
            else if (orderType == orderType.OrderOut)
            {
                var order = db.OrderOuts
                    .Where(oi => oi.O_ID == orderID)
                    .Include(oi => oi.Customer)
                    .Include(oi => oi.OrderProducts)
                    .ThenInclude(op => op.Product)
                    .ThenInclude(p => p.Product_MeasuringUnits)
                    .ThenInclude(pmu => pmu.MeasuringUnit)
                    .FirstOrDefault();
                orderIdLabel.Text = order.O_ID.ToString();
                orderTypeLabel.Text = "Order Out";
                orderDateLabel.Text = order.O_Date.ToString();
                fromTypeLabel.Text = "Customer";
                fromNameLabel.Text = order.Customer.C_Name;
                toTypeLabel.Text = "Warehouse";
                toNameLabel.Text = "Warehouse";

                // make the column shape of the reportGrid first
                reportGrid.Columns.Add("Product", "Product");
                reportGrid.Columns.Add("Quantity", "Quantity");
                reportGrid.Columns.Add("Product Code", "Product Code");
                reportGrid.Columns.Add("Measuring Unit", "Measuring Unit");
                foreach (var item in order.OrderProducts)
                {
                    reportGrid.Rows.Add(item.Product.P_Name, item.Quantity, (MeasuringUnits)item.Product.P_MU);
                }
            }
            else if (orderType == orderType.TransferOrderIn)
            {
                var order = db.TransferOrderIns
                    .Where(oi => oi.O_ID == orderID)
                    .Include(oi => oi.SourceWarehouse)
                    .Include(oi => oi.TargetWarehouse)
                    .Include(oi => oi.OrderProducts)
                    .ThenInclude(op => op.Product)
                    .ThenInclude(p => p.Product_MeasuringUnits)
                    .ThenInclude(pmu => pmu.MeasuringUnit)
                    .FirstOrDefault();
                orderIdLabel.Text = order.O_ID.ToString();
                orderTypeLabel.Text = "Transfer Order In";
                orderDateLabel.Text = order.O_Date.ToString();
                fromTypeLabel.Text = "Source Warehouse";
                fromNameLabel.Text = order.SourceWarehouse.W_Name;
                toTypeLabel.Text = "Target Warehouse";
                toNameLabel.Text = order.TargetWarehouse.W_Name;

                // make the column shape of the reportGrid first
                reportGrid.Columns.Add("Product", "Product");
                reportGrid.Columns.Add("Quantity", "Quantity");
                reportGrid.Columns.Add("Product Code", "Product Code");
                reportGrid.Columns.Add("Measuring Unit", "Measuring Unit");
                foreach (var item in order.OrderProducts)
                {
                    reportGrid.Rows.Add(item.Product.P_Name, item.Quantity, (MeasuringUnits)item.Product.P_MU);
                }
            }
            else if (orderType == orderType.TransferOrderOut)
            {
                var order = db.TransferOrderOuts
                    .Where(oi => oi.O_ID == orderID)
                    .Include(oi => oi.SourceWarehouse)
                    .Include(oi => oi.TargetWarehouse)
                    .Include(oi => oi.OrderProducts)
                    .ThenInclude(op => op.Product)
                    .ThenInclude(p => p.Product_MeasuringUnits)
                    .ThenInclude(pmu => pmu.MeasuringUnit)
                    .FirstOrDefault();
                orderIdLabel.Text = order.O_ID.ToString();
                orderTypeLabel.Text = "Transfer Order Out";
                orderDateLabel.Text = order.O_Date.ToString();
                fromTypeLabel.Text = "Source Warehouse";
                fromNameLabel.Text = order.SourceWarehouse.W_Name;
                toTypeLabel.Text = "Target Warehouse";
                toNameLabel.Text = order.TargetWarehouse.W_Name;

                // make the column shape of the reportGrid first
                reportGrid.Columns.Add("Product", "Product");
                reportGrid.Columns.Add("Quantity", "Quantity");
                reportGrid.Columns.Add("Product Code", "Product Code");
                reportGrid.Columns.Add("Measuring Unit", "Measuring Unit");
                foreach (var item in order.OrderProducts)
                {
                    reportGrid.Rows.Add(item.Product.P_Name, item.Quantity, (MeasuringUnits)item.Product.P_MU);
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
