using Uni.Sage.Shared.Communication;

namespace Uni.Sage.Application.Contrats.Requests
{
    public class DocEnteteRequest : Request
    {
        //public int ID { get; set; }
        //public string CodeTiers { get; set; }
        public DateTime Date { get; set; }
        //public string NumeroDocument { get; set; }
        //public string Souche { get; set; }
        public string Reference { get; set; }
        public string Client_Inty { get; set; }
        //public string ReferenceAffaire { get; set; }
        //public int CodeRepresentant { get; set; }
        //public int CodeDepot { get; set; }
        //public string ReferenceExpedition { get; set; }
        //public int Status { get; set; }
        //public int CodeCategorieTarifaire { get; set; }
        //public string Entete1 { get; set; }
        //public string Entete2 { get; set; }
        //public string Entete3 { get; set; }
        //public string Entete4 { get; set; }

        public List<DocLigneRequest> DocLignes { get; set; }
    }
}