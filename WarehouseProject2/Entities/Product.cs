using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseProject2.Entities
{
    public class Product
    {
        public int P_ID { get; set; }
        public string P_Name { get; set; }
        public string P_Code { get; set; }
        public Type P_Type { get; set; }
        public int P_MU { get; set; }


        public ICollection<Product_TransferOrderIn> Product_TransferOrderIns { get; set; }
        public ICollection<Product_TransferOrderOut> Product_TransferOrderOuts { get; set; }
        public ICollection<Product_OrderIn> Product_OrderIns { get; set; }
        public ICollection<Product_OrderOut> Product_OrderOuts { get; set; }
        public ICollection<Product_Warehouse> Product_Warehouses { get; set; }
        public ICollection<Product_MeasuringUnit> Product_MeasuringUnits { get; set; }

    }
}
