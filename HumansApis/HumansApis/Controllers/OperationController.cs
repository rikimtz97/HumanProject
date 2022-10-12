using HumansApis.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HumansApis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperationController : Controller
    {
        private readonly IOperationRepository operationrepository;

        public OperationController(IOperationRepository operationrepository)
        {
            this.operationrepository = operationrepository;
        }
        [HttpPost]
        public async Task<IActionResult> Plus(double a, double b, double c)
        {
            if(a == null || b == null || c == null)
            {

                return BadRequest();

            }
            var result = await operationrepository.Plus(a, b, c);
            return Ok (result);
        }
        [HttpGet]
        public async Task<IActionResult> Plus2([FromHeader] double a, [FromHeader] double b, [FromHeader] double c)
        {
            if (a == null || b == null || c == null)
            {

                return BadRequest();

            }
            var result = await operationrepository.Plus(a, b, c);
            return Ok(result);
        }

        }
}
