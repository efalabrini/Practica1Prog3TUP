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
            day = day.Trim();

            switch (day)
            {
                case "Lunes":
                case "Martes":
                case "Miércoles":
                case "Jueves":
                case "Viernes":
                    string dayN = "No es fin de semana";
                    return dayN;
                case "Sábado":
                case "Domingo":
                    string dayS = "Es fin de semana";
                    return dayS;
                default:
                    string dayError = "Error Inválido.";
                    return dayError;
            }
        }
    }
}