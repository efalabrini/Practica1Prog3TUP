using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ejercicio4 : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get([FromQuery] int num1, [FromQuery] int num2)
        {
            string message;

            if (num1 > num2)
            {
                message = "El número 1 es mayor que el número 2";
            }
            else if (num1 < num2)
            {
                message = "El número 2 es mayor que el número 1";
            }
            else
            {
                message = "El número 1 es igual al número 2";
            }

            return Ok(message);
        }
    }
}
