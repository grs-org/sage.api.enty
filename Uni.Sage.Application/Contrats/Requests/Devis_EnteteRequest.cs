using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Application.Contrats.Requests
{
    public class Devis_EnteteRequest
    {
        public string ConnectionName { get; set; }
        public string Souche { get; set; }
        public string Client { get; set; }
        public string Reference { get; set; }
        public DateTime Date { get; set; }
        public string Affaire { get; set; }
        public string CompteCollectif { get; set; }
        public List<Devis_LigneRequest> Lignes { get; set; }
    }

}
