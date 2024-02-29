using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Domain.Entities
{
    public class Devis_EnteteResponse
    {
        public string Piece { get; set; }
        public DateTime Date { get; set; }
        public string Reference { get; set; }
        public string CodeClient { get; set; }
        public int CodeCollaborateur { get; set; }
        public string Collaborateur { get; set; }
        public int CodeDepot { get; set; }
        public string Depot { get; set; }
        public string CodeAffaire { get; set; }
        public string Affaire { get; set; }
        public int CodeSouche { get; set; }
        public string Souche { get; set; }
        public string CodeCompteCollectif { get; set; }
        public string CompteCollectif { get; set; }
        public decimal TotalHT { get; set; }
        public decimal TotalTTC { get; set; }
    }
}
