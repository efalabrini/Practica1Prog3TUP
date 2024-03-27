using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string nombre, [FromQuery] string edad [FromQuery])
        {

            string mensaje = $"Te llamas {nombre} y tenés {edad}";

            return mensaje;
        }
    }
}
