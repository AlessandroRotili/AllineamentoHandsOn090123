using AllineamentoHandsOn._01_BusinessLayer._01_Interfaces;
using AllineamentoHandsOn._01_BusinessLayer.models.ad_models;
using AllineamentoHandsOn._01_BusinessLayer.models.company_models;
using AllineamentoHandsOn._02_DataAccessLayer.Interfaces;
using AutoMapper;

namespace AllineamentoHandsOn._01_BusinessLayer._02_Services
{
    public class AdService : IAdService
    {
        private readonly IAdDAS _adDAS;
        public readonly IMapper _mapper;
        public AdService(IAdDAS adDAS, IMapper m)
        {
            _adDAS = adDAS;
            _mapper = m;
        }

        public IEnumerable<GetAdModel> GetAll()
        {
            var myAds = _adDAS.Get();
            return _mapper.Map<IEnumerable<GetAdModel>>(myAds);
        }

        public Ad Create(PostAd a)
        {
            var adToADD = _mapper.Map<Ad>(a);
            return _adDAS.Add(adToADD);
        }

        public Ad Update(PostAd a, int id)
        {
            var toUp = _mapper.Map<Ad>(a);
            return _adDAS.Update(toUp, id);
        }

        public void Delete(int id)
        {
            _adDAS.Delete(id);
        }
    }
}
