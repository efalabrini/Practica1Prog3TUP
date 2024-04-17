using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] double precio, [FromQuery] string formaDePago, [FromQuery] string numTarj)
        {
            string response;

            if (precio <= 0)
            {
                return "Costo no puede ser negativo";
            }

            if (formaDePago.Equals("tarjeta", StringComparison.OrdinalIgnoreCase))
            {
                if (numTarj.Length != 16)
                {
                    return "El numero de tarjeta tiene que tener 16 digitos";
                }

                double total = precio * 1.10;
                response = $"El valor a pagar con tarjeta es: {total}";
                return response;
            }
            else if (formaDePago.Equals("efectivo", StringComparison.OrdinalIgnoreCase))
            {
                response = $"El valor a pagar con efectivo es: {precio}";
                return response;
            }
            else
            {
                response = "La forma de pago no es válida. Debe ser 'efectivo' o 'tarjeta'.";
                return response;
            }
        }
    }
}