using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int price, [FromQuery] string pay, [FromQuery] string numCard)
        {
            
            if (price <= 0)
            {
                return "Error: El precio del producto debe ser un valor positivo.";
            }

            double Total = price; 

            
            if (pay.ToUpper() == "TARJETA")
            {
                
                if (numCard.Length != 16)
                {
                    return "Error: El número de tarjeta debe contener 16 dígitos.";
                }

                
                Total *= 1.10; 
            }

            return $"El valor a pagar es: {Total}";
        }
    }
}
