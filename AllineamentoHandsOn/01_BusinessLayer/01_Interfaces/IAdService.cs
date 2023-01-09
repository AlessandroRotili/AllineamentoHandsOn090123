using AllineamentoHandsOn._01_BusinessLayer.models.ad_models;
using AllineamentoHandsOn._01_BusinessLayer.models.company_models;

namespace AllineamentoHandsOn._01_BusinessLayer._01_Interfaces
{
    public interface IAdService
    {
        public IEnumerable<GetAdModel> GetAll();
        public Ad Create(PostAd a);
        public Ad Update(PostAd a, int id);
        public void Delete(int id);
    }
}
