using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string name, [FromQuery] string city)
        {
            string greeting = $"Hola {name} bienvenido a {city}.";
            return greeting;
        }
    }
}

//2) Pedir por parámetro un nombre de persona y el nombre de una ciudad
//(no hace falta que sean reales o comprobarlos) y mostrar por consola el
//siguiente mensaje Hola  <nombre>  bienvenido a  <ciudad>. Utilizar Interpolación.