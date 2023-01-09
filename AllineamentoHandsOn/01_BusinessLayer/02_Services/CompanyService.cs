using AllineamentoHandsOn._01_BusinessLayer.models.company_models;
using AllineamentoHandsOn._02_DataAccessLayer.Interfaces;
using AllineamentoHandsOn._03_PresentationLayer.Controllers;

namespace AllineamentoHandsOn._01_BusinessLayer._02_Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyDAS _das;
        public CompanyService(ICompanyDAS das)
        { 
            _das = das;
        }
        public Company Create(Company c)
        {
            return _das.Add(c);
        }

        public void Delete(int id)
        {
            _das.Delete(id);
        }

        public IEnumerable<Company> GetAll()
        {
            return _das.Get();
        }

        public Company Update(Company company, int id)
        {
            return _das.Update(company, id);
        }
    }
}
