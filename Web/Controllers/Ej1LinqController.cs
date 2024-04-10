using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1LinqController : ControllerBase
    {
        [HttpGet()]
        public List<int> Get() // devuelvo lista de enteros
        {
           List<int> numeritos = [30, 45, 1000, 120, 134, 78, 90, 12, 21, 65, 87];
           List<int> numeritosFiltrados = numeritos.Where(numero => numero > 30 && numero < 100).ToList();
           
           return numeritosFiltrados;

           
        }
    }
}
