using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Products.Service.Controllers
{
    [ApiController]
    [Route("/api/products")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}