using Autorizacion_y_autenticacion_JWT.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Autorizacion_y_autenticacion_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            var list = ProductsConstants.Products;

            return Ok(list);
        }
    }
}
