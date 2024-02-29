using Uni.Sage.Shared.Extention;

namespace Uni.Sage.Domain.Entities
{
    public class F_DOCLIGNE
    {
        public short DO_Domaine { get; set; }
        public short DO_Type { get; set; }
        public string CT_Num { get; set; }
        public string DO_Piece { get; set; }
        public string DL_PieceBC { get; set; }
        public string DL_PieceBL { get; set; }
        public DateTime DO_Date { get; set; }
        public DateTime DL_DateBC { get; set; }
        public DateTime DL_DateBL { get; set; }
        public int DL_Ligne { get; set; }
        public string DO_Ref { get; set; }
        public short DL_TNomencl { get; set; }
        public short DL_TRemPied { get; set; }
        public short DL_TRemExep { get; set; }
        public string AR_Ref { get; set; }
        public string DL_Design { get; set; }
        public decimal DL_Qte { get; set; }
        public decimal DL_QteBC { get; set; }
        public decimal DL_QteBL { get; set; }
        public decimal DL_PoidsNet { get; set; }
        public decimal DL_PoidsBrut { get; set; }
        public decimal DL_Remise01REM_Valeur { get; set; }
        public short DL_Remise01REM_Type { get; set; }
        public decimal DL_Remise02REM_Valeur { get; set; }
        public short DL_Remise02REM_Type { get; set; }
        public decimal DL_Remise03REM_Valeur { get; set; }
        public short DL_Remise03REM_Type { get; set; }
        public decimal DL_PrixUnitaire { get; set; }
        public decimal DL_PUBC { get; set; }
        public decimal DL_Taxe1 { get; set; }
        public short DL_TypeTaux1 { get; set; }
        public short DL_TypeTaxe1 { get; set; }
        public decimal DL_Taxe2 { get; set; }
        public short DL_TypeTaux2 { get; set; }
        public short DL_TypeTaxe2 { get; set; }
        public int CO_No { get; set; }
        public int AG_No1 { get; set; }
        public int AG_No2 { get; set; }
        public decimal DL_PrixRU { get; set; }
        public decimal DL_CMUP { get; set; }
        public short DL_MvtStock { get; set; }
        public int DT_No { get; set; }
        public string AF_RefFourniss { get; set; }
        public string EU_Enumere { get; set; }
        public decimal EU_Qte { get; set; }
        public short DL_TTC { get; set; }
        public int DE_No { get; set; }
        public int cbDE_No { get;  set; }
        public short DL_NoRef { get; set; }
        public short DL_TypePL { get; set; }
        public decimal DL_PUDevise { get; set; }
        public decimal DL_PUTTC { get; set; }
        public int DL_No { get; set; }
        public DateTime DO_DateLivr { get; set; }
        public string CA_Num { get; set; }
        public decimal DL_Taxe3 { get; set; }
        public short DL_TypeTaux3 { get; set; }
        public short DL_TypeTaxe3 { get; set; }
        public decimal DL_Frais { get; set; }
        public short DL_Valorise { get; set; }
        public string AR_RefCompose { get; set; }
        public short DL_NonLivre { get; set; }
        public string AC_RefClient { get; set; }
        public decimal DL_MontantHT { get; set; }
        public decimal DL_MontantTTC { get; set; }
        public short DL_FactPoids { get; set; }
        public short DL_Escompte { get; set; }
        public string DL_PiecePL { get; set; }
        public DateTime DL_DatePL { get; set; }
        public decimal DL_QtePL { get; set; }
        public string DL_NoColis { get; set; }
        public int DL_NoLink { get; set; }
        public string RP_Code { get; set; }
        public int DL_QteRessource { get; set; }
        public DateTime DL_DateAvancement { get; set; }
        public string PF_Num { get; set; }
        public string DL_CodeTaxe1 { get; set; }
        public string DL_CodeTaxe2 { get; set; }
        public string DL_CodeTaxe3 { get; set; }
        public int DL_PieceOFProd { get; set; }
        public string DL_PieceDE { get; set; }
        public DateTime DL_DateDE { get; set; }
        public decimal DL_QteDE { get; set; }
        public string DL_Operation { get; set; }
        public short cbProt { get; set; }
        public string cbCreateur { get; set; }
        public DateTime cbModification { get; set; }
        public int cbReplication { get; set; }
        public short cbFlag { get; set; }
        public DateTime cbCreation { get; set; }
        public int DL_NoSousTotal { get; set; }
        public int CA_No { get; set; }
        public short DO_DocType { get; set; }
        public int cbHashVersion { get; set; }

        // constricteur

        public F_DOCLIGNE()
        {
            DO_Domaine = 0;
            DO_Type = 0;
            CT_Num = "";
            DO_Piece = "";
            DL_PieceBC ="";
            DL_PieceBL = "";
            DO_Date = DateTime.MinValue.MinGregorianDate();
            DL_DateBC =DateTime.MinValue.MinGregorianDate();
            DL_DateBL =DateTime.MinValue.MinGregorianDate();
            DL_Ligne = 0;
            DO_Ref ="";
            DL_TNomencl = 0;
            DL_TRemPied =  0;
            DL_TRemExep =  0;
            AR_Ref = "";
            DL_Design = "";
            DL_Qte = 0;
            DL_QteBC = 0;
            DL_QteBL = 0;
            DL_PoidsNet = 0;
            DL_PoidsBrut = 0;
            DL_Remise01REM_Valeur = 0;
            DL_Remise01REM_Type =  0;
            DL_Remise02REM_Valeur = 0;
            DL_Remise02REM_Type = 0;
            DL_Remise03REM_Valeur = 0;
            DL_Remise03REM_Type =  0;
            DL_PrixUnitaire =  0;
            DL_PUBC = 0;
            DL_Taxe1 = 0;
            DL_TypeTaux1 = 0;
            DL_TypeTaxe1 = 0;
            DL_Taxe2 = 0;
            DL_TypeTaux2 = 0;
            DL_TypeTaxe2 = 0;
            CO_No = 7;
            AG_No1 = 0;
            AG_No2 = 0;
            DL_PrixRU = 0;
            DL_CMUP = 0;
            DL_MvtStock = 0;
            DT_No = 0;
            AF_RefFourniss = "";
            EU_Enumere ="";
            EU_Qte = 0;
            DL_TTC = 1;
            DE_No = 1;
            cbDE_No = 0;
            DL_NoRef = 1;
            DL_TypePL = 0;
            DL_PUDevise = 0;
            DL_PUTTC = 0;
            DL_No =  0;
            DO_DateLivr =DateTime.MinValue.MinGregorianDate();
            CA_Num =  "";
            DL_Taxe3 = 0;
            DL_TypeTaux3 =  0;
            DL_TypeTaxe3 = 0;
            DL_Frais = 0;
            DL_Valorise = 1;
            AR_RefCompose = null;
            DL_NonLivre =  0;
            AC_RefClient = "";
            DL_MontantHT = 0;
            DL_MontantTTC = 0;
            DL_FactPoids =0;
            DL_Escompte =0;
            DL_PiecePL ="";
            DL_DatePL = DateTime.MinValue.MinGregorianDate();
            DL_QtePL = 0;
            DL_NoColis = "";
            DL_NoLink = 0;
            RP_Code = null;
            DL_QteRessource = 0;
            DL_DateAvancement = DateTime.MinValue.MinGregorianDate();
            PF_Num =  "";
            DL_CodeTaxe1 = null;
            DL_CodeTaxe2 =  null;
            DL_CodeTaxe3 = null;
            DL_PieceOFProd = 0;
            DL_PieceDE = "";
            DL_DateDE = DateTime.MinValue.MinGregorianDate();
            DL_QteDE = 0;
            DL_Operation = "";
            DL_NoSousTotal = 0;
            CA_No =0;
            DO_DocType = 1;
            cbProt =  0;
            cbCreateur = "ENTY";
            cbModification =  DateTime.Now;
            cbReplication = 0;
            cbFlag =  0;
            cbCreation = DateTime.Now;
            cbHashVersion = 1;
        }
    }
}