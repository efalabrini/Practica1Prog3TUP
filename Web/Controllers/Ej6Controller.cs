using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller 
    {
        [HttpGet]
        public string Get([FromQuery] double price, [FromQuery] string pay, [FromQuery] string card = "")
        {
            if (price <= 0)
            {
                return "el precio tiene que ser positivo";
            }

            string typeOfPay = pay.Trim().ToLower();

            if (typeOfPay == "tarjeta")
            {

                string valueOfCard = card.Trim();
                if (valueOfCard.Length != 16)
                {
                    return "la longitud tiene que ser de 16 digitos";
                }
                price *= 1.1;
            }

            return $"El valor a pagar es: {price}";
        }
    }
}


