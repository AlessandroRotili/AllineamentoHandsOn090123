using AllineamentoHandsOn._01_BusinessLayer.models.company_models;
using AllineamentoHandsOn._03_PresentationLayer.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AllineamentoHandsOn.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly ILogger<CompanyController> _logger;
        private readonly ICompanyService _companyService;

        public CompanyController(ILogger<CompanyController> logger, ICompanyService companyService)
        {
            _logger = logger;
            _companyService = companyService; 
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_companyService.GetAll());
        }

        [HttpPost]
        public IActionResult Add([FromBody] PostCompany c) {

            return Ok(_companyService.Create(c));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] PostCompany c)
        {
            _companyService.Update(c, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _companyService.Delete(id);
            return NoContent();
        }
    }
}