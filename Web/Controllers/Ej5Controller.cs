using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string nombreDia)
        {
            string[] diaSemana = ["lunes", "martes", "miercoles", "jueves", "viernes"];
            string[] finSemana = ["sabado", "domingo"];
            
            nombreDia = nombreDia.ToLower().Trim();

            if(diaSemana.Contains(nombreDia))
            {
                return "Ese día es un día de la semana";

            }else if (finSemana.Contains(nombreDia))
            {
                return "Ese día es un día del fin de semana";
            }

            return "Incorrecto.Usted ha ingresado un dia que no coincide con ningún dia existente";
        }
    }
}






