namespace Uni.Sage.Api.Enty.Model
{
    public class TarifClientResponse
    {
        public string Reference { get; set; }
        public string Designation { get; set; }
        public int CodeCategorie { get; set; }
        public string CategorieTarifaire { get; set; }
        public decimal PrixVente { get; set; }
        public decimal Remise { get; set; }
    }
}
