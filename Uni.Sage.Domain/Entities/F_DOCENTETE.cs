using Uni.Sage.Shared.Extention;

namespace Uni.Sage.Domain.Entities
{
    public partial class F_DOCENTETE
    {
        public short DO_Domaine { get; set; }
        public short DO_Type { get; set; }
        public string DO_Piece { get; set; }
        public DateTime DO_Date { get; set; }
        public string DO_Ref { get; set; }
        public string DO_Tiers { get; set; }
        public int CO_No { get; set; }
        public short DO_Period { get; set; }
        public short DO_Devise { get; set; }
        public decimal DO_Cours { get; set; }
        public int DE_No { get; set; }
        public int cbDE_No { get; set; }
        public int LI_No { get; set; }
        public int cbLI_No { get; set; }
        public string CT_NumPayeur { get; set; }
        public short DO_Expedit { get; set; }
        public short DO_NbFacture { get; set; }
        public short DO_BLFact { get; set; }
        public decimal DO_TxEscompte { get; set; }
        public short DO_Reliquat { get; set; }
        public short DO_Imprim { get; set; }
        public string CA_Num { get; set; }
        public string DO_Coord01 { get; set; }
        public string DO_Coord02 { get; set; }
        public string DO_Coord03 { get; set; }
        public string DO_Coord04 { get; set; }
        public short DO_Souche { get; set; }
        public DateTime DO_DateLivr { get; set; }
        public short DO_Condition { get; set; }
        public short DO_Tarif { get; set; }
        public short DO_Colisage { get; set; }
        public short DO_TypeColis { get; set; }
        public short DO_Transaction { get; set; }
        public short DO_Langue { get; set; }
        public decimal DO_Ecart { get; set; }
        public short DO_Regime { get; set; }
        public short N_CatCompta { get; set; }
        public short DO_Ventile { get; set; }
        public int AB_No { get; set; }
        public DateTime DO_DebutAbo { get; set; }
        public DateTime DO_FinAbo { get; set; }
        public DateTime DO_DebutPeriod { get; set; }
        public DateTime DO_FinPeriod { get; set; }
        public string CG_Num { get; set; }
        public short DO_Statut { get; set; }
        public string DO_Heure { get; set; }
        public int CA_No { get; set; }
        public int CO_NoCaissier { get; set; }
        public short DO_Transfere { get; set; }
        public short DO_Cloture { get; set; }
        public string DO_NoWeb { get; set; }
        public short DO_Attente { get; set; }
        public short DO_Provenance { get; set; }
        public string CA_NumIFRS { get; set; }
        public int MR_No { get; set; }
        public short DO_TypeFrais { get; set; }
        public decimal DO_ValFrais { get; set; }
        public short DO_TypeLigneFrais { get; set; }
        public short DO_TypeFranco { get; set; }
        public decimal DO_ValFranco { get; set; }
        public short DO_TypeLigneFranco { get; set; }
        public decimal DO_Taxe1 { get; set; }
        public short DO_TypeTaux1 { get; set; }
        public short DO_TypeTaxe1 { get; set; }
        public decimal DO_Taxe2 { get; set; }
        public short DO_TypeTaux2 { get; set; }
        public short DO_TypeTaxe2 { get; set; }
        public decimal DO_Taxe3 { get; set; }
        public short DO_TypeTaux3 { get; set; }
        public short DO_TypeTaxe3 { get; set; }
        public short DO_MajCpta { get; set; }
        public string DO_Motif { get; set; }
        public string CT_NumCentrale { get; set; }
        public string DO_Contact { get; set; }
        public short DO_FactureElec { get; set; }
        public short DO_TypeTransac { get; set; }
        public DateTime DO_DateLivrRealisee { get; set; }
        public DateTime DO_DateExpedition { get; set; }
        public string DO_FactureFrs { get; set; }
        public string DO_PieceOrig { get; set; }
        public Guid DO_GUID { get; set; }
        public short DO_EStatut { get; set; }
        public short DO_DemandeRegul { get; set; }
        public int ET_No { get; set; }
        public short DO_Valide { get; set; }
        public short DO_Coffre { get; set; }
        public string DO_CodeTaxe1 { get; set; }
        public string DO_CodeTaxe2 { get; set; }
        public string DO_CodeTaxe3 { get; set; }
        public decimal DO_TotalHT { get; set; }
        public short DO_StatutBAP { get; set; }
        public string cbCreateur { get; set; }
        public DateTime cbModification { get; set; }
        public short DO_Escompte { get; set; }
        public short DO_DocType { get; set; }
        public short DO_TypeCalcul { get; set; }
        public decimal DO_TotalHTNet { get; set; }
        public decimal DO_TotalTTC { get; set; }
        public decimal DO_NetAPayer { get; set; }
        public decimal DO_MontantRegle { get; set; }

        public string DO_AdressePaiement { get; set; }
        public short DO_PaiementLigne { get; set; }
        public short DO_MotifDevis { get; set; }
        public short DO_Conversion { get; set; }
        public int cbProt { get; set; }
        public int cbReplication { get; set; }
        public int cbFlag { get; set; }
        public DateTime cbCreation { get; set; }
        public int cbHashVersion { get; set; }
        public string DO_FactureFile { get; set; }
        public string Source_BC { get; set; }
        public string Client_Inty { get; set; }
        public List<F_DOCLIGNE> F_DOCLIGNEs { get; set; }

        public F_DOCENTETE()
        {
            DO_Domaine = 0;
            DO_Type = 0;
            DO_Piece = "";
            DO_Date =DateTime.MinValue.MinGregorianDate();
            DO_Ref ="";
            DO_Tiers ="";
            CO_No = 1;
            DO_Period =1;
            DO_Devise = 0;
            DO_Cours =0;
            DE_No = 1;
            cbDE_No = DE_No;
            LI_No = cbLI_No = 1;
            CT_NumPayeur ="";
            DO_Expedit = 1;
            DO_NbFacture = 1;
            DO_BLFact = 0;
            DO_TxEscompte =0;
            DO_Reliquat = 0;
            DO_Imprim = 0;
            CA_Num = "";
            DO_Coord01 ="";
            DO_Coord02 ="";
            DO_Coord03 ="";
            DO_Coord04 ="";
            DO_Souche = 1;
            DO_DateLivr = DateTime.MinValue.MinGregorianDate();
            DO_Condition = 1;
            DO_Tarif = 1;
            DO_Colisage = 1;
            DO_TypeColis =1;
            DO_Transaction = 11;
            DO_Langue =  0;
            DO_Ecart =0;
            DO_Regime = 21;
            N_CatCompta = 1;
            DO_Ventile = 0;
            AB_No = 0;
            DO_DebutAbo =DateTime.MinValue.MinGregorianDate();
            DO_FinAbo =  DateTime.MinValue.MinGregorianDate();
            DO_DebutPeriod = DateTime.MinValue.MinGregorianDate();
            DO_FinPeriod = DateTime.MinValue.MinGregorianDate();
            CG_Num = "";
            DO_Statut = 0;
            DO_Heure =  "000" + DateTime.Now.ToString("HHmmss");
            CA_No =  0;
            CO_NoCaissier =  0;
            DO_Transfere = 0;
            DO_Cloture = 0;
            DO_NoWeb = "";
            DO_Attente = 0;
            DO_Provenance = 0;
            CA_NumIFRS = "";
            MR_No = 0;
            DO_TypeFrais = 0;
            DO_ValFrais = 0;
            DO_TypeLigneFrais = 0;
            DO_Conversion = 0;
            DO_TypeFranco = 0;
            DO_ValFranco = 0;
            DO_TypeLigneFranco = 0;
            DO_Taxe1 = 0;
            DO_TypeTaux1 = 0;
            DO_TypeTaxe1 = 0;
            DO_Taxe2 = 0;
            DO_TypeTaux2 = 0;
            DO_TypeTaxe2 = 0;
            DO_Taxe3 = 0;
            DO_TypeTaux3 = 0;
            DO_TypeTaxe3 = 0;
            DO_MajCpta = 0;
            DO_Motif = "";
            CT_NumCentrale = null;
            DO_Contact = "";
            DO_FactureElec = 0;
            DO_TypeTransac = 0;
            DO_DateLivrRealisee = DateTime.MinValue.MinGregorianDate();
            DO_DateExpedition = DateTime.MinValue.MinGregorianDate();
            DO_FactureFrs ="";
            DO_PieceOrig = "";
            DO_EStatut = 0;
            DO_DemandeRegul = 0;
            ET_No = 0;
            DO_Valide = 0;
            DO_Coffre = 0;
            DO_CodeTaxe1 = null;
            DO_CodeTaxe2 = null;
            DO_CodeTaxe3 = null;
            DO_TotalHT = 0;
            DO_StatutBAP = 0;
            DO_Escompte = 1;
            DO_DocType = 0;
            DO_TypeCalcul = 0;
            DO_FactureFile = null;
            DO_TotalHTNet = 0;
            DO_TotalTTC = 0;
            DO_NetAPayer = 0;
            DO_MontantRegle = 0;
            DO_AdressePaiement = "";
            DO_PaiementLigne = 0;
            DO_MotifDevis = 0;
            DO_Conversion = 0;
            cbProt = 0;
            cbCreateur = "ENTY";
            cbModification = DateTime.Now;
            cbReplication = 0;
            cbFlag = 0;
            cbCreation = DateTime.Now;
            cbHashVersion = 1;

            this.F_DOCLIGNEs = new List<F_DOCLIGNE>();
        }
    }
}