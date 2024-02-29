using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Domain.Entities
{
    public  class ClientResponse
    {
        public string CodeClient { get; set; }
        public string Intitule { get; set; }
        public int EnSommeil { get; set; }
        public string CompteCollectif { get; set; }
        public string Qualite { get; set; }
        public int CodeTarif { get; set; }
        public string Tarif { get; set; }
        public string Classement { get; set; }
        public string Contact { get; set; }

        public string Telephone { get; set; }
        public string Pays { get; set; }
        public string Ville { get; set; }
        public string Adresse { get; set; }
        public string Identifiant { get; set; }
        public int CodeCollaborateur { get; set; }
        public string Collaborateur { get; set; }
        public int CodeDepot { get; set; }
        public string Depot { get; set; }
    }
}
