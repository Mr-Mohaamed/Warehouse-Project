using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseProject2.Entities
{
    public class Product_Warehouse
    {
        public int P_ID { get; set; }
        public int W_ID { get; set; }
        public DateTime ExpiryDate { get; set; } = DateTime.Now + TimeSpan.FromDays(180);
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
