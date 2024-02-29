using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Domain.Entities
{
    public  class CollaborateurResponse
    {
        public int CodeCollaborateur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Fonction { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string CodeRegion { get; set; }
        public string Pays { get; set; }
        public string Service { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        //public int EnSommeil { get; set; }
    }
}
