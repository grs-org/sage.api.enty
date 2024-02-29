using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uni.Sage.Api.Enty.Classes
{
    public class F_TAXE
    {
        public string TA_Code { get; set; }
        public string TA_Intitule { get; set; }
        public decimal TA_Taux { get; set; }
        public string CG_Num { get; set; }
        public short TA_Type { get; set; }
        public short TA_Sens { get; set; }
    }
}
