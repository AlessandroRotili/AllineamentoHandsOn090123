using AllineamentoHandsOn._01_BusinessLayer.models.ad_models;
using AutoMapper;

namespace AllineamentoHandsOn._01_BusinessLayer.AutoMapper_Profiles
{
    public class AdProfiles : Profile
    {
        public AdProfiles() {
            CreateMap<Ad, PostAd>();
            CreateMap<Ad, PostAd>().ReverseMap();
            CreateMap<PostAd, Ad>();
            CreateMap<GetAdModel, Ad>().ReverseMap();
            CreateMap<GetAdModel, Ad>();
            CreateMap<Ad, GetAdModel>();

        }
    }
}
