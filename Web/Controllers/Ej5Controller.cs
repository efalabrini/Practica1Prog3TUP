using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class Ej5Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string dia)
        {

            
            dia = dia.Trim();

            
            dia = dia.ToLower();

            
            if (dia.Equals("sábado") || dia.Equals("sabado") || dia.Equals("domingo"))
            {
                return ("es fin de semana");
            }
            
            else if (dia.Equals("lunes") || dia.Equals("martes") || dia.Equals("miércoles") || dia.Equals("miercoles") || dia.Equals("jueves") || dia.Equals("viernes"))
            {
                return ("NO es fin de semana");
            }
            else
            {
                return ("el nombre del día ingresado no es valido");
            }
        }
    }
}
    

