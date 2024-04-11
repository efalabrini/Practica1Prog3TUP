using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj2Controller : ControllerBase
    {
        [HttpGet]
        public List<string> Get([FromQuery] List<string> lista)
        {

            var query = from l in lista
                        where l.Length >= 5
                        select l.ToUpper();
            return query.ToList();
        }
    }
}

/*2) Escriba una consulta que devuelva palabras de al menos 5 caracteres y las ponga en mayúsculas. 
Ejemplo: "computadora", "usb" → "COMPUTADORA"
*/