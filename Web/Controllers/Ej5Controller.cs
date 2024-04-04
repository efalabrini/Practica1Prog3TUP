using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string dia)
        {
            string respuesta = "no hay dia ingresado aún";

              if(dia.Contains(" ")){
                dia = dia.Trim();
              }
              if(dia.Equals("lunes", StringComparison.OrdinalIgnoreCase)){
                    respuesta = $"NO es fin de semana. Dia: {dia}";
              }
              else if(dia.Equals("martes", StringComparison.OrdinalIgnoreCase)){
                    respuesta = $"NO es fin de semana. Dia: {dia}";
              }
              else if(dia.Equals("miercoles", StringComparison.OrdinalIgnoreCase)){
                    respuesta = $"NO es fin de semana. Dia: {dia}";
              }
              else if(dia.Equals("jueves", StringComparison.OrdinalIgnoreCase)){
                    respuesta = $"NO es fin de semana. Dia: {dia}";
              }
              else if(dia.Equals("viernes", StringComparison.OrdinalIgnoreCase)){
                    respuesta = $"NO es fin de semana. Dia: {dia}";
              }
              else if(dia.Equals("sabado", StringComparison.OrdinalIgnoreCase)){
                    respuesta = $"SIII es fin de semana. Dia: {dia}";
              }
              else if(dia.Equals("domingo", StringComparison.OrdinalIgnoreCase)){
                    respuesta = $"SIII es fin de semana. Dia: {dia}";
              }

            return respuesta;




        }
    }
}