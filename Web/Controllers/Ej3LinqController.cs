using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> palabritas)
        {
           var query = from string word in palabritas 
                       where word.First() == 'b' && word.Last() == 'r'
                       select word;

            return query.ToList(); 

        }
    }
}