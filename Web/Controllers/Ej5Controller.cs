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
            string[] weekDays = ["lunes", "martes", "miercoles", "jueves", "viernes"];
            string[] weekendDays = ["sabado", "domingo"];

            string noSpaceDay = day.Trim().ToLower();
            
            if (weekDays.Contains(noSpaceDay))
            {
                return $"El día ingresado, {day}, NO corresponde al fin de semana.";
            }
            
            else if (weekendDays.Contains(noSpaceDay))
            {
                return $"El día ingresado, {day}, corresponde al fin de semana.";
            }

            else
            {
                return "ERROR: El campo ingresado no corresponde a un día.";
            }
        }
    }
}
