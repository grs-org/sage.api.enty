using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Domain.Entities
{
    public class AffaireResponse
    {
        public string Code { get; set; }
        public string Intitule { get; set; }
        public string PlanAnalytique { get; set; }
        public int Domaine { get; set; }
    }
}
