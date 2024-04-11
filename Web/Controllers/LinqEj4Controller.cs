using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj4Controller : ControllerBase
    {
        [HttpGet]
        public List<int> Get([FromQuery] List<int> lista)
        {
            var query = (from int l in lista
                         orderby l descending
                         select l).Take(5);
            return query.ToList();
        }
    }
}

/*
4) Escriba una consulta que devuelva los 5 primeros números de la lista de enteros en orden descendente.
Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21
*/