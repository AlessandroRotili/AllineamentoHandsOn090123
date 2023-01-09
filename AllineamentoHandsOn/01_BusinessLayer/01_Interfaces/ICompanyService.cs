using AllineamentoHandsOn._01_BusinessLayer.models.company_models;

namespace AllineamentoHandsOn._03_PresentationLayer.Controllers
{
    public interface ICompanyService
    {
        public IEnumerable<Company> GetAll();
        public Company Create(Company c);
        public Company Update(Company company, int id);
        public void Delete(int id);
    }
}
