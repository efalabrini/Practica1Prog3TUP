using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int productValue , [FromQuery] string payment)
        {
            float targetsurcharge = productValue + ((productValue / 100) * 10);
            if (productValue > 0)
            {
                if(payment == "tarjeta")
                {
                    return $"tiene un 10% de recargo su producto ahora vale {targetsurcharge}";
                }
                else if (payment == "efectivo")
                {
                    return $"su producto  vale {productValue}";
                }
                else
                {
                    return "ingrese si es efectivo o tarjeta";
                }
            }
            else
            {
                return "ingrese un numero positivo";
            } 
        }
    }
}
