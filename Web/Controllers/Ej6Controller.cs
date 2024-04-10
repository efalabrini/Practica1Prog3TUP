using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class Ej6Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] float amount, [FromQuery] string cardNumber, [FromQuery] string paymentMethod)
        {
            if (amount > 0)
            {
                double surchargePrice = amount * 1.10;

                if (paymentMethod == "tarjeta")
                {
                    int numberOfDigits = cardNumber.Length;

                    if (numberOfDigits == 16)
                    {
                        return $"El valor a pagar con tarjeta es de ${surchargePrice}";
                    }

                    else
                    {
                        return $"ERROR: El numero de tarjeta ingresado no es válido. Ingrese un número de 16 dígitos.";
                    }
                }
                else if (paymentMethod == "efectivo")
                {
                    return $"El precio a pagar en efectivo es de ${amount}";
                }
                else
                {
                    return "ERROR: La forma de pago ingresada no es válida.";
                }
            }
            else
            {
                return "ERROR: El monto ingresado debe ser positivo.";
            }
        }
    }
}