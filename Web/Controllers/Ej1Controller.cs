using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string nombre, [FromQuery] string pais)
        {
            string fusion = $"Su nombre es {nombre} y es de {pais}";
            
            return fusion ;
        }
    }
}
