using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int precio, [FromQuery] string pago, [FromQuery] string numTarjeta)
        {
            string respuesta;
            double precioConRecargo;
        
            if(precio <= 0){
                respuesta = "Por favor ingrese un precio positivo";
            }

            if(pago.Contains(" ")){
                pago = pago.Trim();
            }
            
            if(pago.Equals("tarjeta", StringComparison.OrdinalIgnoreCase)){
                if(numTarjeta.Length == 16){
                    precioConRecargo = precio + (precio * 0.10);
                    respuesta = $"Tarjeta: ${precioConRecargo}. Tiene 10% de recargo\nNro. Digitos: {numTarjeta.Length}";
                }
                else{
                    respuesta = "Su numero de tarjeta no tiene 16 digitos. Ingrese nuevamente";
                }
            }
            else{
                respuesta = $"Efectivo: {precio}. No tiene recargo";
            }

                return respuesta;
        }
    }
}