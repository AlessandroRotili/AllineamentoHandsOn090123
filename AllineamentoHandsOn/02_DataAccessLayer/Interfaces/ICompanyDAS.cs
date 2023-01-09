using AllineamentoHandsOn._01_BusinessLayer.models.company_models;

namespace AllineamentoHandsOn._02_DataAccessLayer.Interfaces
{
    public interface ICompanyDAS
    {
        public Company Add(Company company);
        public Company Update(Company company, int id);
        public void Delete(int id);

        public IEnumerable<Company> Get();
    }
}
