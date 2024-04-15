using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Collections.Generic;

namespace web.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj5Controller : ControllerBase
    {
        [HttpGet]
        public List<string> Get([FromQuery] List <int> numeros)
        {
            var query = from num in numeros
                        where Math.Pow(num,2) > 20
                        select $"{num}-{Math.Pow(num, 2)}";


                return query.ToList();
            
        }
    }
}

//5) Escriba una consulta que devuelva una lista de números y sus cuadrados en formato: "número - cuadrado" sólo si el cuadrado es mayor que 20
//Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900”


