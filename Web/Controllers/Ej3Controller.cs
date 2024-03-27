//bloques de microsoft
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    //clase
    public class Ej3Controller : ControllerBase
    {
        //metodo
        [HttpGet()]
        public string Get([FromQuery] string nombre, [FromQuery] string anios)
        {
            string result = $"Te llamas {nombre} y tienes {anios} años";
            return result;
        }
    }
}
