using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int num1, [FromQuery] int num2)
        {

            string mensaje;

            if (num1 > num2)
            {
                mensaje = $"{num1} es mayor a {num2}";
            }
            else if(num1 < num2){
                mensaje = $"{num2} es mayor a {num1}";
            }
            else
            {
                mensaje = "Ambos numeros son iguales";
            }

            return mensaje;

        }
    }
}
