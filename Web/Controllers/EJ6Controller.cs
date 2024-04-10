using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string payMethod, [FromQuery] float price, [FromQuery] string card = "" )
        {

            if (price <= 0)
            {
                return("ingrese un valor valido y positivo para el precio del producto:");
            }

            string newPayM = payMethod.Trim().ToLower();

            if (newPayM == "tarjeta")
            {

                string cardNumber = card.Trim();
                if (cardNumber.Length != 16)
                {
                    return "La longitud tiene que ser de 16 digitos";
                }

                else
                {
                    float priceCard = price * 1.10f;
                    string resultado = $"El precio final es de: {priceCard}";
                    return (resultado);
                }
                
            }
            
            else if (newPayM == "efectivo")
            {
                string resultado = $"El precio final es de: {price}";
                return (resultado);
            }
            else
            {
                return "Metodo de pago no admitido";
            }
        }
    }
}
