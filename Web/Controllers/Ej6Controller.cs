using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get([FromQuery] double product, [FromQuery] string pay)
        {
            pay = pay.ToLower();

            if (product > 0)
            {
                if (pay == "efectivo")
                {
                    return Ok($"Usted tiene que pagar ${product} en efectivo");
                }
                else if (pay == "tarjeta")
                {
                    double priceWithSurcharge = product * 1.1;
                    return Ok($"Usted tiene que pagar ${priceWithSurcharge} con tarjeta");
                }
                else
                {
                    return BadRequest("Método de pago no válido");
                }
            }
            else
            {
                return BadRequest("Ingrese un precio válido");
            }
        }
    }
}
