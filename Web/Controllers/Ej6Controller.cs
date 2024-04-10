using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] float price, [FromQuery] string payment, [FromQuery] string cardNum)
        {
            payment = payment.Trim().ToLower();

            if (payment == "efectivo")
            {
                return ($"el monto a pagar es de ${price}");
            }
            else if (payment == "tarjeta")
            {
                cardNum = cardNum.Trim();

                if (cardNum.Length == 16)
                {
                    return ($"El total a pagar es de {1.1 * price}");
                }
                else
                {
                    return ("el número de tarjeta debe tener 16 caracteres");
                }
            }
            else
            {
                return ("el metodo de pago es erroneo");
            }
        }
    }
}
