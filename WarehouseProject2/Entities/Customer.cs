using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseProject2.Entities
{
    public class Customer
    {
        public int C_ID { get; set; }
        public string C_Name { get; set; }
        public string C_Mobile{ get; set; }
        public string C_Phone { get; set; }
        public string C_Email { get; set; }
        public string C_Fax { get; set; }
        public string C_Site { get; set; }

        public ICollection<OrderOut> OrderOuts { get; set; }
    }
}
