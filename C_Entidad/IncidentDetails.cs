using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Entidad
{
    public class IncidentDetails
    {
        public Int32 IncidentDetailsID { get; set; }
        public Int32 IncidentID_FK { get; set; }
        public String IncidentDescripcion { get; set; }
        public String Type { get; set; }
    }
}
