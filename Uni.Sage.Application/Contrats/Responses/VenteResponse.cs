using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Application.Contrats.Responses
{
    public class VenteResponse
    {
        public string Piece { get; set; }
        public DateTime Date { get; set; }
        public string Reference { get; set; }
        public string Statut { get; set; }
        public string CodeClient { get; set; }
        public string Client { get; set; }
        public int CodeCollaborateur { get; set; }
        public string Collaborateur { get; set; }
        public int CodeDepot { get; set; }
        public string Depot { get; set; }
        public string Tarif { get; set; }
        public decimal TotalHT { get; set; }
        public decimal TotalTTC { get; set; }
    }
}
