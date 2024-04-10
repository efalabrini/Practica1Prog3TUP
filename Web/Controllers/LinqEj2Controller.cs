using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj2Controller : ControllerBase
    {
        [HttpGet()]

        public string[] Get([FromQuery] string[] word)
        {
            var wordQuery =
                from w in word
                where w.Length > 4
                select w.ToUpper();
            
            return wordQuery.ToArray();
        }
    }
}
