using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller: ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string name, [FromQuery] string age) 
        {
            string result = $"Te llamas {name} y tiene {age} años!!!!";
            return result;
        }

    }
}


//3) Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: “Te llamas ” <nombre> ” y tienes ” <años> ” años”
