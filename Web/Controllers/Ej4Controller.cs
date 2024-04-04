using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet()]

        public string Get([FromQuery] int num1, [FromQuery] int num2) {

            


            if (num1 > num2)
            {
                 return $"El mayor es el {num1}";
            }
            else if(num1 == num2) {
                return $"El {num1} es igual a {num2}";
            }else
            {
                return $"El mayor es el {num2}";
            }
                
        }
    }
}
