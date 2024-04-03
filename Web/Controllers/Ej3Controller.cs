using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller
    {
        [HttpGet()]
        public string Get([FromQuery] string nombre, [FromQuery] string anios)
        {
            string resultado = $"Te llamas {nombre} y tiene {anios} anios";
            return resultado;



        }

    }
}
