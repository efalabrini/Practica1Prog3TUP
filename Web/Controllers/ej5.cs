using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ej5 : ControllerBase

    {
        [HttpGet()]
        public string Get([FromQuery] string nDia)           
        {
            string nDiaSinEspacio = nDia.Trim();
            string diaSabado = "sabado";
            string diaDomingo = "domingo";

            if (diaSabado.Equals(nDiaSinEspacio, StringComparison.OrdinalIgnoreCase) || diaDomingo.Equals(nDiaSinEspacio, StringComparison.OrdinalIgnoreCase)) 
            {
                return "Es fin de semana";
            }
            else
            {

                return "no es fin de semana";
            }


        }

    }
}
