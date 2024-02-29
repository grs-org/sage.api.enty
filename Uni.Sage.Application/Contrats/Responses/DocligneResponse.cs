using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni.Sage.Shared.Communication;

namespace Uni.Sage.Application.Contrats.Responses
{
    public class DocligneResponse : Response
    {
        public string Reference { get; set; }
        public string Designation { get; set; }
        public int Quantite { get; set; }
        public int Remise { get; set; }
        public int Prix { get; set; }
    }
}
