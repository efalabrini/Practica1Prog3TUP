using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int var1, [FromQuery] int var2)
        {
            if (var1 > var2)
            {
                string result = $"El primer número {var1} es mayor que el segundo número {var2}.";
                return result;

            }
            else if (var2 > var1)
            {
                string result = $"El segundo número {var2} es mayor que el primer número {var1}.";
                return result;
            }
            else
            {
                string result = $"Los números son iguales.";
                return result;
            }
        }
    }
}