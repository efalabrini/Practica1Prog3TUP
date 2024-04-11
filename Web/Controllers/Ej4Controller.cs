using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int numero1, [FromQuery] int numero2)
        {

            string respuesta;


            if (numero1 > numero2)

            {
                respuesta = $"El primer numero ingresado : {numero1} es el mayor";

            }

            else if (numero2 > numero1)

            {
                respuesta = $"El segundo numero ingresado : {numero2} es el mayor";

            }


            else
            {
                respuesta = "Ambos numeros son iguales";
            }

            return respuesta;
        }
    }
}
