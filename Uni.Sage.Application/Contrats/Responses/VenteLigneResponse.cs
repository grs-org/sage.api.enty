using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Application.Contrats.Responses
{
    public class VenteLigneResponse
    {
        public string Piece { get; set; }
        public DateTime Date  { get; set; }
        public string CodeArticle { get; set; }
        public string Designation { get; set; }
        public decimal Quantite { get; set; }
        public decimal Remise { get; set; }
        public decimal Prix { get; set; }
        public decimal Taxe { get; set; }
        public decimal  MontantHT { get; set; }
        public decimal MontantTTC { get; set; }
    }
}
