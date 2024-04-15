using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj3Controller : ControllerBase
    {
        [HttpGet()]
        public string[] Get([FromQuery] string[] word)
        {


            var wordQuery =
                from w in word
                where w.Substring(0,1).ToLower() == "b" && w.Substring(w.Length - 1, 1).ToLower() == "r"
                select w;

            return wordQuery.ToArray();
        }
    }
}
