using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Domain.Entities
{
    public class Devis_LigneResponse
    {
        public string Piece { get; set; }
        public string PieceBC { get; set; }
        public string PieceBL { get; set; }
        public string PieceDE { get; set; }
        public DateTime Date { get; set; }
        public string CodeClient { get; set; }
        public string Client { get; set; }
        public string Reference { get; set; }
        public string CodeArticle { get; set; }
        public string Designaion { get; set; }
        public string Quantite { get; set; }
        public decimal Remise1 { get; set; }
        public decimal Remise2 { get; set; }
        public decimal Remise3 { get; set; }
        public decimal PrixUnitaire { get; set; }
        public decimal Taxe1 { get; set; }
        public decimal Taxe2 { get; set; }
        public decimal Taxe3 { get; set; }
        public string Gamme1 { get; set; }
        public string Gamme2 { get; set; }
        public string LotSerie { get; set; }
        public string Unite { get; set; }
        public string Depot { get; set; }
        public string Collaborateur { get; set; }
        public string CodeAffaire { get; set; }
        public string Affaire { get; set; }
        public decimal MontantHT { get; set; }
        public decimal MontantTTC { get; set; }
    }
}
