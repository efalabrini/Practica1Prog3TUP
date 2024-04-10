using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string dia)
        {
            if (dia.ToLower().Trim() is "sabado" or "domingo")
            {
                return "Es fin de semana";
            }
            else if (dia.ToLower().Trim() is "lunes" or "martes" or "miercoles" or "jueves" or "viernes") {
                return "Es dia entre semana";
            }
            else {
                return "Respuesta no valida";
            }
        }
    }
}

/*5) Pedir el nombre del día al usuario y decirle si es fin de semana o no.  En caso de error, indicarlo. Se debe poder ingresar, por ejemplo, “Lunes” / “LUNES” / “lunes” / “lUnes” /“  lunes” y debería funcionar. TIP para investigar: Trim() y StringComparison.OrdinalIgnoreCase*/
