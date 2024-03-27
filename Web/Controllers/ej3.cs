using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ej3 : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string name, [FromQuery] string edad) 
        {
            string edade = $"usted se llama {name} y tiene {edad} años";
            return edade;
        }
    }
}
