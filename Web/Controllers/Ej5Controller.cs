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
            string[] daysWeek = ["lunes", "martes", "miercoles", "jueves", "viernes"];
            string[] daysWeekend = ["sabado", "domingo"];
            day = day.ToLower().Trim();
            if (daysWeek.Contains(day)) 
            {
                return $" {day} es un dia de semana ";
            }
            else if (daysWeekend.Contains(day)) 
            {
                return $" {day} es un dia del fin de semana";
            }
            else
            {
                return "Error, el dato ingresado es invalido";       
            }
        }


        
            
           



    }
}
