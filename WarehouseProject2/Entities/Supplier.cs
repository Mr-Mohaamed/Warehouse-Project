using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseProject2.Entities
{
    public class Supplier
    {
        public int S_ID { get; set; }
        public string S_Name { get; set; }
        public string S_Mobile { get; set; }
        public string S_Phone { get; set; }
        public string S_Email { get; set; }
        public string S_Fax { get; set; }
        public string S_Site { get; set; }

        public ICollection<OrderIn> OrderIns { get; set; }
    }
}
