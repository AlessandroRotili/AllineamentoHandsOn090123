using AllineamentoHandsOn._01_BusinessLayer.models.ad_models;

namespace AllineamentoHandsOn._01_BusinessLayer.models.company_models
{
    public class GetCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //public Image? Image { get; set; } = null;

        public List<PostAd>? JobAds { get; set; } = new List<PostAd>();
    }
}
