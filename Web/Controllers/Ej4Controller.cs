using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int number1, [FromQuery] int number2)
        {
            if(number1 > number2)
            {
                return ($"{number1} es mayor que {number2}");
            }else if (number1 < number2)
            {
                return ($"{number2} es mayor que {number1}");
            } else
            {
                return ("Ambos numeros son iguales");
            }
        }
    }
}
