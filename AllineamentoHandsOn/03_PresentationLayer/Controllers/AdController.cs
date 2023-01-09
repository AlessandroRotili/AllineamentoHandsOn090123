using AllineamentoHandsOn._01_BusinessLayer._01_Interfaces;
using AllineamentoHandsOn._01_BusinessLayer.models.ad_models;
using Microsoft.AspNetCore.Mvc;

namespace AllineamentoHandsOn._03_PresentationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdController : ControllerBase
    {
        private readonly IAdService _adService;

        public AdController(IAdService adService)
        {
            _adService = adService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_adService.GetAll());
        }

        [HttpPost] public IActionResult Add([FromBody] PostAd a) { 
            return Ok(_adService.Create(a));    
        }

        [HttpPut("{id}")]
        public  IActionResult Update(int id, [FromBody] PostAd a)
        {
            return Ok(_adService.Update(a, id));
        }
    }
}
