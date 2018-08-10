using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Entidad
{
    public class Supplier
    {
         public Int32 SuplierID { get; set; }
         public String Name { get; set; }
         public String Location { get; set; }
         public Int32 SpaceAvaible { get; set; }
         public Int32 TypeOfService { get; set; }
         public String OpenningHours { get; set; }
    }
}
