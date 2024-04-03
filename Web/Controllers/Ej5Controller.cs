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
                return "Es dia de semana";
            }
            else if (string.Equals(dayinput, "sabado", StringComparison.OrdinalIgnoreCase) ||
                     string.Equals(dayinput, "domingo", StringComparison.OrdinalIgnoreCase))
            {
                return "Es fin de semana";
            }
            else
            {
                return "ingrese un dia valido";
            }
        }

    }
}