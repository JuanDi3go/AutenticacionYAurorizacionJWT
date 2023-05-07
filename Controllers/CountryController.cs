using Autorizacion_y_autenticacion_JWT.Constants;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Autorizacion_y_autenticacion_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        // GET: api/<CountryController>
        [HttpGet]
        public IActionResult Get()
        {
            var listCountry = CountryConstants.Countrys;

            return Ok(listCountry);
        }

    }
}
