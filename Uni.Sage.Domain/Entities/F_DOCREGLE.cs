namespace Uni.Sage.Domain.Entities
{
    public class F_DOCREGLE
    {
        //public  int DR_No { get; set; }
        public short DO_Domaine { get; set; }

        public short DO_Type { get; set; }
        public string DO_Piece { get; set; }
        public short DR_TypeRegl { get; set; }
        public DateTime DR_Date { get; set; }
        public string DR_Libelle { get; set; }
        public decimal DR_Pourcent { get; set; }
        public decimal DR_Montant { get; set; }
        public decimal DR_MontantDev { get; set; }
        public short DR_Equil { get; set; }
        public int EC_No { get; set; }
        public short DR_Regle { get; set; }
        public short N_Reglement { get; set; }
        public short CbProt { get; set; }
        public string CbCreateur { get; set; }
        public DateTime CbModification { get; set; }
        public int CbReplication { get; set; }
        public short CbFlag { get; set; }
        public DateTime CbCreation { get; set; }
        public int CA_No { get; set; }
        public short DO_DocType { get; set; }
        public string DR_AdressePaiement { get; set; }
        public int CbHashVersion { get; set; }

        public F_DOCREGLE(F_DOCENTETE entete)
        {
            this.DO_Domaine=entete.DO_Domaine;
            this.DO_Type=entete.DO_Type;
            this.DO_DocType=entete.DO_DocType;
            this.CA_No=entete.CA_No;
            this.DR_Date=entete.DO_Date;
            this.DO_Piece=entete.DO_Piece;
            this.DR_TypeRegl = 2;
            this.DR_Libelle = "";
            this.DR_Pourcent = 0;
            this.DR_Montant = 0;
            this.DR_MontantDev = 0;
            this.DR_Equil = 1;
            this.EC_No = 0;
            this.DR_Regle = 0;
            this.N_Reglement = 1;
            this.CA_No = 0;
            this.CbProt = 0;
            this.CbCreateur = "ENTY";
            this.CbModification = DateTime.Now;
            this.CbReplication = 0;
            this.CbFlag = 0;
            this.CbCreation = DateTime.Now;
            this.CbHashVersion = 1;
            this.DR_AdressePaiement = "";
        }
    }
}