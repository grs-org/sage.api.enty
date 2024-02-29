using System;
using System.Collections.Generic;

namespace Uni.Sage.Api.Enty.Classes
{
    public class F_ECRITUREC
    {
        public string JO_Num { get; set; }
        public int EC_No { get; set; }
        public DateTime JM_Date { get; set; }
        public int EC_Jour { get; set; }
        public DateTime EC_Date { get; set; }
        public string EC_Piece { get; set; }
        public string EC_RefPiece { get; set; }
        public string CG_Num { get; set; }
        public string CG_NumCont { get; set; }
        public string CT_Num { get; set; }
        public string EC_Intitule { get; set; }
        public DateTime EC_Echeance { get; set; }
        public decimal EC_Parite { get; set; }
        public short N_Devise { get; set; }
        public short EC_Sens { get; set; }
        public string CT_NumCont { get; set; }
        public decimal EC_Devise { get; set; }
        public string TA_Code { get; set; }
        public short TA_Provenance { get; set; }
        public string EC_Reference { get; set; }
        public int EC_NoCloture { get; set; }
        public decimal EC_Montant { get; set; }

        public DateTime EC_MinDate => new DateTime(1753, 1, 1);


        public List<F_ECRITUREA> ECRITUREAs { get; set; }
    }
}