using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string inputDay)
        {
            string response;
            string[] weekDays = ["lunes", "martes", "miercoles", "jueves", "viernes"];
            string[] weekEndDays = ["sabado", "domingo"];

            inputDay = inputDay.Trim();

            if (Array.Exists(weekEndDays, day => day.Equals(inputDay, StringComparison.OrdinalIgnoreCase)))
            {
                response = "Es fin de semana";
            }
            else if (Array.Exists(weekDays, day => day.Equals(inputDay, StringComparison.OrdinalIgnoreCase)))
            {
                response = "No es fin de semana";
            }
            else
            {
                response = "Por favor, ingrese un dia de la semana";
            }

            return response;
        }
    }
}
