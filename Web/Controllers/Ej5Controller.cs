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
            if (day.Trim().Equals("Lunes", StringComparison.OrdinalIgnoreCase) ||
                day.Trim().Equals("Martes", StringComparison.OrdinalIgnoreCase) ||
                day.Trim().Equals("Miercoles", StringComparison.OrdinalIgnoreCase) ||
                day.Trim().Equals("Jueves", StringComparison.OrdinalIgnoreCase) ||
                day.Trim().Equals("Viernes", StringComparison.OrdinalIgnoreCase))
            {
                return "No es fin de semana";
            }
            else if (day.Trim().Equals("Sábado", StringComparison.OrdinalIgnoreCase) ||
                day.Trim().Equals("Domingo", StringComparison.OrdinalIgnoreCase))
            {
                return "Es fin de semana";
            }
            else
            {
                return "Dia no valido";
            }
        }
    }
}