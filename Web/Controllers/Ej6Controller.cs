using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class Ej6Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] float price, [FromQuery] string payMetod = "", [FromQuery] string cardNumber = "") //se le asignan predeterminados para que no se rompa 
                                                                                                                         // si el cliente se olvida de ingresar algun dato
        {
            payMetod = payMetod.Trim().ToLower();

            if (price <= 0)
            {
                return "ERROR: El valor del producto debe ser positivo o mayor a 0";
            }
            else if (payMetod == "tarjeta" || payMetod == "efectivo")
            { 
                if (payMetod == "tarjeta")
                {
                    cardNumber = cardNumber.Trim();

                    if (cardNumber.Length == 16)
                    {
                        return $"El total a pagar es: ${price*1.1}";
                    }
                    else
                    {
                        return "ERROR: El numero de tarjeta es invalido o no ingreso el numero";
                    }  
                }
                else
                {
                    return $"El total a pagar es: ${price}";
                }
            }

            return "ERROR: Ingrese un metodo de pago valido porfavor";
        }
    }
}
