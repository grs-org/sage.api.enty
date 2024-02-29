using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Domain.Entities
{
    public  class F_COLLABORATEUR
    {
        public int CO_No { get; set; }
        public string CO_Nom { get; set; }
        public string CO_Prenom { get; set; }
        public string CO_Fonction { get; set; }
        public string CO_Adresse { get; set; }
        public string CO_Ville { get; set; }
        public string CO_CodeRegion { get; set; }
        public string CO_Pays { get; set; }
        public string CO_Service { get; set; }
        public string CO_Telephone { get; set; }
        public string CO_EMail { get; set; }
    }
}
