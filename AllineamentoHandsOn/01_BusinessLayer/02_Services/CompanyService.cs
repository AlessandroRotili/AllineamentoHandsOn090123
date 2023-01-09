using AllineamentoHandsOn._01_BusinessLayer.models.company_models;
using AllineamentoHandsOn._02_DataAccessLayer.Interfaces;
using AllineamentoHandsOn._03_PresentationLayer.Controllers;
using AutoMapper;

namespace AllineamentoHandsOn._01_BusinessLayer._02_Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyDAS _das;
        private readonly IMapper _m;
        public CompanyService(ICompanyDAS das, IMapper m)
        { 
            _das = das;
            _m = m;
        }
        public Company Create(PostCompany c)
        {
            var toAdd = _m.Map<Company>(c);
            return _das.Add(toAdd);
        }

        public void Delete(int id)
        {
            _das.Delete(id);
        }

        public IEnumerable<GetCompany> GetAll()
        {
            var myCompanies = _das.Get();
            return _m.Map<IEnumerable<GetCompany>>(myCompanies);
        }

        public Company Update(PostCompany company, int id)
        {
            var toUpdate = _m.Map<Company>(company);

            return _das.Update(toUpdate, id);
        }
    }
}
