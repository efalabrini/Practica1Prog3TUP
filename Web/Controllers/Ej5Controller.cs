using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string day)
        {
            day = day.Trim().ToLower();
            if (day == "lunes" || day == "martes" || day == "miercoles" || day == "miércoles" || day == "jueves" || day == "viernes")
            {
                return ($"{day} es día de semana");
            }
            else if (day == "sabado" || day == "sábado" || day == "domingo")
            {
                return ($"{day} es fin de semana");
            }
            else
            {
                return ($"{day} no representa a ningún día");
            }
        }
    }
}
