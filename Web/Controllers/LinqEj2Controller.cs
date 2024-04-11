using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace web.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj2Controller : ControllerBase
    {
        [HttpGet]
        public List<string> Get([FromQuery] List <string> lista)
        {
            var query = from string l in lista
                        where l.Length >= 5
                        select l.ToUpper();

            return query.ToList();
        }
    }
}
