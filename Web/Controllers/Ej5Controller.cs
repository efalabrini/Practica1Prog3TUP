using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller
    {
        [HttpGet()]
        public string Get([FromQuery] string day)
        {
            string daySelected = day.Trim();
            switch (daySelected.ToLower())
            {
                case "lunes":
                case "martes":
                case "miércoles":
                case "jueves":
                    return "no";
                case "viernes":
                case "sábado":
                case "domingo":
                    return "yes";
                default:
                    return "día no válido";
            }

        }
    }
}



