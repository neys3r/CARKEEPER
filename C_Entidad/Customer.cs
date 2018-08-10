using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Entidad
{
    public class Customer
    {
        public Int32 CustomerID { get; set; }
        public String Name { get; set; }
        public Int32 ID { get; set; }
        public Int32 Phone { get; set; }
        public Int32 VehicleID_FK { get; set; }
        public String email { get; set; }
       
    }
}
