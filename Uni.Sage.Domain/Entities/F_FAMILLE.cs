using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Domain.Entities
{
    public class F_FAMILLE
    {
        public string FA_CodeFamille { get; set; }
        public string FA_Intitule { get; set; }
        public string FA_Central { get; set; }
        public string FA_UniteVen { get; set; }
        public DateTime CbCreation { get; set; }
        public DateTime CbModification { get; set; }
    }
}
