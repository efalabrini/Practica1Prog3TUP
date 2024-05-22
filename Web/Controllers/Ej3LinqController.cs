using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> words)
        {
            var query = 
                from w in words
                where w.ToLower()[0] == 'b' && w.ToLower().Last() == 'r'
                select w.ToLower();

            return query.ToList(); 
        }   
    }
}
