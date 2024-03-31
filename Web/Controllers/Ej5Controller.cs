using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet()]

        public string Get([FromQuery] string day)
        {
            string dayinput = day.Trim();
            if (string.Equals(dayinput, "lunes", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(dayinput, "martes", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(dayinput, "miércoles", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(dayinput, "jueves", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(dayinput, "viernes", StringComparison.OrdinalIgnoreCase))
            {
                return "NO ES FIN DE SEMANA";
            }
            else if (string.Equals(dayinput, "sabado", StringComparison.OrdinalIgnoreCase) ||
                     string.Equals(dayinput, "domingo", StringComparison.OrdinalIgnoreCase))
            {
                return "ES FIN DE SEMANA";
            }
            else
            {
               return "ingrese un dia correctamente";
            }
        }
    
    }
}
