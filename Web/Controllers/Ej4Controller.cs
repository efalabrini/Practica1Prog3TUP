using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller
    {
        [HttpGet()]
        public string Get([FromQuery] int num1, [FromQuery] int num2)
        {
            if (num1 > num2) {
            return $"{num1} es mayor que {num2}";
            }
            else if (num1 < num2)
            {
                return $"{num2} es mayor que {num1}";
            }
            else
            {
                return "Son iguales";
            }
        }
    }
}
