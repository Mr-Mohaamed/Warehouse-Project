using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseProject2.Entities
{
    public class TransferOrderOut
    {
        public int O_ID { get; set; }
        //date gives  the current date
        public DateTime O_Date { get; set; } = DateTime.Now;
        public int SourceWarehouse_ID { get; set; }
        public int TargetWarehouse_ID { get; set; }


        public Warehouse SourceWarehouse { get; set; }
        public Warehouse TargetWarehouse { get; set; }
        public ICollection<Product_TransferOrderOut> OrderProducts { get; set; }
    }
}
