using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseProject2.Entities
{
    public class Warehouse
    {
        public int W_ID { get; set; }
        public string W_Name { get; set; }
        public string W_Address { get; set; }
        public string Manager_Name { get; set; }

        public ICollection<Product_Warehouse> Product_Warehouses { get; set; }
        public ICollection<OrderIn> OrderIns { get; set; }
        public ICollection<OrderOut> OrderOuts { get; set; }
        public ICollection<TransferOrderIn> SourceTransferOrderIns { get; set; }
        public ICollection<TransferOrderIn> TargetTransferOrderIns { get; set; }
        public ICollection<TransferOrderOut> SourceTransferOrderOuts { get; set; }
        public ICollection<TransferOrderOut> TargetTransferOrderOuts { get; set; }
    }
}
