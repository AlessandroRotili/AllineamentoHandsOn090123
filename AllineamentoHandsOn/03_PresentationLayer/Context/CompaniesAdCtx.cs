using AllineamentoHandsOn._01_BusinessLayer.models.ad_models;
using AllineamentoHandsOn._01_BusinessLayer.models.company_models;
using AllineamentoHandsOn._01_BusinessLayer.models.images;
using Microsoft.EntityFrameworkCore;

namespace AllineamentoHandsOn._03_PresentationLayer.Context
{
    public class CompaniesAdCtx : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Ad> Ads { get; set; }

        //public DbSet<Image> Images { get; set; }

        public CompaniesAdCtx(DbContextOptions<CompaniesAdCtx> options)
        : base(options)
        {

        }
    }
}
