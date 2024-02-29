using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Domain.Entities
{
    public class ArticleResponse
    {
        public string Reference { get; set; }
        public string Designation { get; set; }
        public string Famille { get; set; }
        public string CodeFamille { get; set; }
        public short EnSommiel { get; set; }
        public int SuiviStock { get; set; }
        public decimal PoidsBrut { get; set; }
        public decimal PoidsNet { get; set; }
        public string Unite { get; set; }
        public decimal PrixVente { get; set; }

    }
    public class ArticleParDepotResponse
    {
        public string Reference { get; set; }
        public string Designation { get; set; }
        public decimal QuantiteReel { get; set; }
        public decimal Montant { get; set; }
        public int CodeDepot { get; set; }
        public string Depot { get; set; }

    }
    public class StockArticleResponse
    {
        public string Reference { get; set; }
        public string Designation { get; set; }
        public decimal QuantiteReel { get; set; }
        public decimal Montant { get; set; }
        public decimal QuantiteReserve { get; set; }
        public int CodeDepot { get; set; }

    }
    public class ArticleParPrixResponse
    {
        public string Reference { get; set; }
        public string Designation { get; set; }
        public string Famille { get; set; }
        public string CodeFamille { get; set; }
        public decimal PrixVente { get; set; }
    }
}
