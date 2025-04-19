using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseProject2.Entities
{
    public class OrderIn
    {
        public int O_ID { get; set; }
        //date gives  the current date
        public int S_ID { get; set; }
        public int W_ID { get; set; }
        public DateTime O_Date { get; set; } = DateTime.Now;

        public Supplier Supplier { get; set; }
        public Warehouse Warehouse { get; set; }
        public List<Product_OrderIn> OrderProducts { get; set; } = new();
    }
}
