using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace web.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj1Controller : ControllerBase
    {
        [HttpGet]
        public List<int> Get([FromQuery] List <int> lista)
        {
            var query = from int l in lista
                        where l >= 30 && l <= 100
                        select l;

            return query.ToList();
        }
    }
}

//1) Dada una lista de números enteros, escriba una consulta que devuelva la lista de números mayores que 30 y menores que 100.
//Ejemplo: [67, 92, 153, 15] → 67, 92

