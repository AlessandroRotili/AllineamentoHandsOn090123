using AllineamentoHandsOn._01_BusinessLayer.models.company_models;
using AllineamentoHandsOn._02_DataAccessLayer.Interfaces;
using AllineamentoHandsOn._03_PresentationLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace AllineamentoHandsOn._02_DataAccessLayer.Services
{
    public class CompanyDAS : ICompanyDAS
    {
        private readonly CompaniesAdCtx _ctx;

        public CompanyDAS(CompaniesAdCtx ctx)
        {
            _ctx = ctx;
        }

        public Company Add(Company company)
        {
            var added = _ctx.Add(company);
            _ctx.SaveChanges();
            return added.Entity;
        }

        public void Delete(int id)
        {
            var toDelete = _ctx.Companies.Single(c => c.Id== id);
            _ctx.Companies.Remove(toDelete);
            _ctx.SaveChanges();
        }

        public IEnumerable<Company> Get()
        {
            return _ctx.Companies.Include(c => c.JobAds);
        }

        public Company Update(Company company, int id)
        {
            try
            {
                var toMod = _ctx.Companies.Single(c => c.Id == id);
                toMod.Name = company.Name;
                toMod.Description = company.Description;
                var updated =  _ctx.Companies.Update(toMod);
                _ctx.SaveChanges();
                return updated.Entity;
            }
            catch
            {
                return Add(company);
            }
        }
    }
}
