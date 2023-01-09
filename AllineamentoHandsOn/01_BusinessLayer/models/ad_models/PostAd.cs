namespace AllineamentoHandsOn._01_BusinessLayer.models.ad_models
{
    public class PostAd
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public double RAL { get; set; }
        public int CompanyId { get; set; }

        public senority RequiredSenority { get; set; }
    }
}
