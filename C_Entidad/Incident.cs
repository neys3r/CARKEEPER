using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Entidad
{
    public class Incident
    {
        public Int32 IncidentID { get; set; }
        public String Status { get; set; }
        public String Location { get; set; }
        public DateTime date { get; set; }
        public Int32 CustomerID_FK { get; set; }
        public Int32 AgentID_FK { get; set; }
        public Int32 SuplierID_FK { get; set; }
    }
}
