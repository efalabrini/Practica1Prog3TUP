using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ej6 : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string formaPago, [FromQuery] double priceObject)
        {
            string tipoPago = formaPago.Trim();
            string targeta = "targeta";
            string efectivo = "efectivo";

            if (targeta.Equals(tipoPago, StringComparison.OrdinalIgnoreCase))
            {

                double newPriceObject = priceObject * 1.10;

                return $"al precio inicial se le suma 10 % por usar tarjeta , el precio ahora es {newPriceObject}";
            }
            else if (efectivo.Equals(tipoPago, StringComparison.OrdinalIgnoreCase))
            {
                return $"Como usted pago en efectivo el precio se mantiene {priceObject}";
            }
            else
            {
                return "Ingrese bien la forma de pago"; 
            }



        }
    }
}
