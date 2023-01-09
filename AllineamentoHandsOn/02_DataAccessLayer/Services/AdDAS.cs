using AllineamentoHandsOn._01_BusinessLayer.models.ad_models;
using AllineamentoHandsOn._01_BusinessLayer.models.company_models;
using AllineamentoHandsOn._02_DataAccessLayer.Interfaces;
using AllineamentoHandsOn._03_PresentationLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace AllineamentoHandsOn._02_DataAccessLayer.Services
{
    public class AdDAS : IAdDAS
    {
        private readonly CompaniesAdCtx _ctx;

        public AdDAS(CompaniesAdCtx ctx)
        {
            _ctx = ctx;
        }

        public Ad Add(Ad Ad)
        {
            var added = _ctx.Add(Ad);
            _ctx.SaveChanges();
            return added.Entity;
        }

        public void Delete(int id)
        {
            var toDelete = _ctx.Ads.Single(a => a.Id == id);    
            _ctx.Ads.Remove(toDelete);
        }

        public IEnumerable<Ad> Get()
        {
            return _ctx.Ads.Include(a => a.Company);  
        }

        public Ad Update(Ad Ad, int id)
        {
            try
            {
                var toMod = _ctx.Ads.Single(a => a.Id == id);
                toMod.Title = Ad.Title;
                toMod.Description = Ad.Description;
                toMod.RAL = Ad.RAL;
                toMod.RequiredSenority= Ad.RequiredSenority;
                var updated = _ctx.Ads.Update(toMod);
                return updated.Entity;
            }
            catch
            {
                return Add(Ad);
            }
        }
    }
}
