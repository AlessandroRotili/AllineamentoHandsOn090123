using AllineamentoHandsOn._01_BusinessLayer.models.ad_models;
using AllineamentoHandsOn._01_BusinessLayer.models.company_models;

namespace AllineamentoHandsOn._01_BusinessLayer._01_Interfaces
{
    public interface IAdService
    {
        public IEnumerable<Ad> GetAll();
        public Company Create(Ad a);
        public Company Update(Ad a, int id);
        public void Delete(int id);
    }
}
