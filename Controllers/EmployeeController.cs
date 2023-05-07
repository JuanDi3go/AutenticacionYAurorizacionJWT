using Autorizacion_y_autenticacion_JWT.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Autorizacion_y_autenticacion_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = ("Administrador"))]
        public IActionResult Get()
        {
            var list = EmployeeConstants.Employees;

            return Ok(list);
        }
    }
}
