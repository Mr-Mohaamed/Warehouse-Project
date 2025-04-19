using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseProject2.Entities
{
    public class Product_MeasuringUnit
    {
        public int P_ID { get; set; }
        public int MU_ID { get; set; }
        public Product Product { get; set; }
        public MeasuringUnit MeasuringUnit { get; set; }
    }
}
