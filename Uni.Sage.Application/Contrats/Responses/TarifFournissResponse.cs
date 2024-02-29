using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Application.Contrats.Responses
{
    public class TarifFournissResponse
    {
        public string Reference { get; set; }
        public string Designation { get; set; }
        public string CodeFournisseur { get; set; }
        public string Fournisseur { get; set; }
        public string ReferenceFourniss { get; set; }
        public decimal PrixAchat { get; set; }
        public decimal PrixDev { get; set; }
        public decimal Remise { get; set; }
    }
}
