using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] double price, [FromQuery] string paymentMethod, [FromQuery] long cardNumber)
        {

            string mensaje;

            if (price < 0)
            {
                return "El monto debe ser positivo";
            }
            else
            {
                if (paymentMethod.ToLower().Trim() is "tarjeta")
                {
                    mensaje = (cardNumber.ToString().Length != 16) ? "Numero de tarjeta no valido" : $"El total a pagar es {price * 1.10}";
                }
                else if (paymentMethod.ToLower().Trim() is "efectivo")
                {
                    mensaje = $"El total a pagar es {price}";
                }
                else { mensaje = "Error en el metodo de pago"; }

                return mensaje;
            }
        }
    }
}

/*6) Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el número de la misma(inventado), verificar que sean 16 dígitos e informar el valor a pagar con un 10% de recargo.*/
