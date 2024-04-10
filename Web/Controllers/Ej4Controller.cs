using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class Ej4Controller : ControllerBase

    {
        [HttpGet()]

        public string Get([FromQuery] int num1, [FromQuery] int num2)
        {
            if (num1 > num2)
            {
                return $"El numero {num1} es el mayor";
            }

            else if (num1 < num2)
            {
                return $"El numero {num2} es el mayor";
            }
            else
            {
                return $"los numeros son iguales";
            }
        }


    }
}
