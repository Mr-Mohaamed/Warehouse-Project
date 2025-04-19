using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseProject2.Entities
{
    public class OrderOut
    {
        public int O_ID { get; set; }
        //date gives  the current date
        public DateTime O_Date { get; set; } = DateTime.Now;
        public int C_ID { get; set; }
        public int W_ID { get; set; }


        public Customer Customer { get; set; }
        public Warehouse Warehouse { get; set; }
        public List<Product_OrderOut> OrderProducts { get; set; }
    }
}
