using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Domain.Entities
{
    public class F_ARTSTOCK
    {
		public string AR_Ref {get;set;}
		public int DE_No {get;set;}
		public decimal AS_QteMini  {get;set;}
		public decimal AS_QteMaxi {get;set;}
		public decimal AS_MontSto {get;set;}
		public decimal AS_QteSto {get;set;}
		 public decimal AS_QteRes {get;set;}
		public decimal AS_QteCom {get;set;}
		public int AS_Principal {get;set;}
        public decimal AS_QteResCM { get; set; }
        public decimal AS_QteComCM { get; set; }
        public decimal AS_QtePrepa {get;set;}
		public int DP_NoPrincipal {get;set;}
		public int DP_NoControle {get;set;}
		public decimal AS_QteAControler {get;set;}
		public int AS_Mouvemente {get;set;}
		public int cbProt {get;set;}
		public string cbCreateur {get;set;}
		public DateTime cbModification {get;set;}
		public int cbReplication {get;set;}
		public int cbFlag {get;set;}
		public DateTime cbCreation {get;set;}
		public string cbCreationUser {get;set;}
		public F_ARTSTOCK()
		{
			DE_No = 1;
			AS_QteMini = 0;
			AS_QteMaxi = 0;
			AS_MontSto = 0;
			AS_QteSto = 0;
			AS_QteCom = 0;
			AS_Principal = 1;
			AS_QteResCM = 0;
			AS_QteComCM = 0;
			AS_QtePrepa = 0;
			DP_NoPrincipal = 0;
			DP_NoControle = 0;
			AS_QteAControler = 0;
			AS_Mouvemente = 0;
			cbProt = 0;
			cbCreateur = "ENTY";
			cbModification = DateTime.Now;
			cbReplication = 0;
			cbFlag = 0;
			cbCreation = DateTime.Now;
			cbCreationUser = null;

        }
    }
}
