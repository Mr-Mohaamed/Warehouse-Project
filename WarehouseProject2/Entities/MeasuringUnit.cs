using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseProject2.Entities
{
    public enum Type
    {
        Weight,
        Volume,
        Quantity
    }
    public class MeasuringUnit
    {
        public int MU_ID { get; set; }
        public string MU_Name { get; set; }
        public string MU_ShortName { get; set; }
        public Type MU_Type { get; set; }

        public ICollection<Product_MeasuringUnit> Product_MeasuringUnits { get; set; }
    }
}
