using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string nombre, [FromQuery] string edad)
        {
            string result = $"Te llamas {nombre} y tenes {edad} años";
            return result;
        }
    }
}
