using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace Web.Controllers
{


    [Route("api/[controller]")]
    [ApiController]

    public class Ej5Controller : ControllerBase
    {

    [HttpGet()]

     public string Get([FromQuery] string nombreDia)
      

        {
            string respuesta;


            if (nombreDia == "lunes" || nombreDia == "martes" || nombreDia == "miercoles" || nombreDia == "jueves" || nombreDia == "viernes")

            { 
                respuesta = "Es un dia de la semana";
             }

       
           else if (nombreDia == "sabado" || nombreDia =="domingo")
            {
                respuesta = "NO es un dia de la semana";
            }


            else
            {
                respuesta = "hay un error flaco"; 
            }


            return respuesta;
        
        
        
        
        
        }







    }
}
