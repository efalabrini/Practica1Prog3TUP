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
            string response = "Es fin de semana";
            day = day.ToLower();
            string[] week = new string[] { "lunes", "martes", "miércoles", "jueves", "viernes", "sabado", "domingo" };

            bool containsDaysWeek = week.Any(days =>
               day.Trim().Contains(days, StringComparison.OrdinalIgnoreCase));
            if (containsDaysWeek & (day.Trim() == "sabado" | day.Trim() == "domingo"))
            {
                response = "Fin de semana";
            }
            else if (containsDaysWeek)
            {
                response = "Es un dia de semana";
            }
            else
            {
                response = "Expresion invalida";
            }

            return response;

        }
    }
}

//5) Pedir el nombre del día al usuario y decirle si es fin de semana o no.  
//   En caso de error, indicarlo. Se debe poder ingresar, por ejemplo, “Lunes” / “LUNES” / “lunes” / “lUnes” /            
//   “  lunes” y debería funcionar. TIP para investigar: Trim() y StringComparison.OrdinalIgnoreCase
