using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller:ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int var1, [FromQuery] int var2)
        {
            string respuesta;
            if (var1 > var2)
            {
                respuesta = $"el numero {var1} es mayor";
            }
            else if (var2 > var1)
            {
                respuesta = $"el numero {var2} es mayor";
            }
            else
            {
                respuesta = $"Los numeros son iguales";
            }
            return respuesta;

            
        }
    }
}
