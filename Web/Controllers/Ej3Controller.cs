using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string name, [FromQuery] int age) 
        {
            string respuesta = $"Te llamas {name} y tienes {age} años ";
            return respuesta;

        }

    }
}
