using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class Ej5Controller : ControllerBase

    {
        [HttpGet()]

        public string Get([FromQuery] string days)
        {

            string[] week = ["lunes", "martes", "miércoles", "jueves", "viernes"];
            string[] weekeend = [ "sábado", "domingo"] ;

            days = days.ToLower().Trim();

            if (week.Contains(days)) 
            {
                return $"{days} es un dia de semana";
            }
            else if (weekeend.Contains(days))
            {
                return $"{days} es un dia del fin de semana";
            }
            else
            {
                return "Error, ese dia no existe";
            }
        }
    }
}
