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
            string[] dayWeek = ["lunes", "martes", "miercoles", "jueves", "viernes"];
            string[] dayWeekend = ["sabado", "domingo"];

            day = day.ToLower().Trim();

            if (dayWeek.Contains(day)) 
            {
                return "El dia ingresado NO pertenece al fin de semana";
            }
            else if (dayWeekend.Contains(day)) 
            {
                return "El dia ingresado Si pertenece al fin de semana";
            }

            return "ERROR. No se ingreso un dia";
        }
    }
}
