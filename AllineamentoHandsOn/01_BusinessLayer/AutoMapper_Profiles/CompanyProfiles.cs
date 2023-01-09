using AllineamentoHandsOn._01_BusinessLayer.models.company_models;
using AutoMapper;

namespace AllineamentoHandsOn._01_BusinessLayer.AutoMapper_Profiles
{
    public class CompanyProfiles : Profile
    {
        public CompanyProfiles()
        {
            CreateMap<Company, PostCompany>();
            CreateMap<Company, PostCompany>().ReverseMap();
            CreateMap<PostCompany, Company >();
            CreateMap<Company, CompanyLight>();

        }
    }
}
