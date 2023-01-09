using AllineamentoHandsOn._01_BusinessLayer.models.ad_models;
using AllineamentoHandsOn._01_BusinessLayer.models.company_models;

namespace AllineamentoHandsOn._02_DataAccessLayer.Interfaces
{
    public interface IAdDAS
    {
        public Ad Add(Ad Ad);
        public Ad Update(Ad Ad, int id);
        public void Delete(int id);

        public IEnumerable<Ad> Get();
    }
}
