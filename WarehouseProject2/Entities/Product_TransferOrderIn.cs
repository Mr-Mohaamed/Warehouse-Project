using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseProject2.Entities
{
    public class Product_TransferOrderIn
    {
        public int O_ID { get; set; }
        public int P_ID { get; set; }
        public int Quantity { get; set; }
        public TransferOrderIn TransferOrderIn { get; set; }
        public Product Product { get; set; }
    }
}
