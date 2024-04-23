using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ejercicio3 : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string name, [FromQuery] string age)
        {
            string YourDates = $"Te llamas {name} y tienes: {age} años.";
            return YourDates;
        }
    }
}

