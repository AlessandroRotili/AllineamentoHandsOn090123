using AllineamentoHandsOn._01_BusinessLayer.models.company_models;

namespace AllineamentoHandsOn._01_BusinessLayer.models.ad_models
{
    public class Ad
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public double RAL { get; set; }

        public senority RequiredSenority { get; set; }

        public Company Company { get; set; }
    }
}
