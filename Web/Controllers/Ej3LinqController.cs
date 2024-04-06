using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3LinqController : Controller
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> list)
        {
            var result = list.Where(word => word.Trim().ToLower()[0] == 'b' && word.Trim().ToLower()[word.Trim().Length - 1] == 'r').ToList(); 
                                            // si no ponia asi el subindice y ponia un espacio al final de la palabra daba error xq con los metodos no se midifica la longitud
                                            // y al querer usar la longitud de la palaba sin los metodos me daba una long mas grande y se salia de rango
            return result;

        }
    }
}