using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class Ej3Controller
    {
        [HttpGet()]
        public string Get([FromQuery] string nombre, [FromQuery] string edad)
        {

            string result = $"Hola su nombre es {nombre} y tiene {edad} anios";
            return result;
        }
    }
}
