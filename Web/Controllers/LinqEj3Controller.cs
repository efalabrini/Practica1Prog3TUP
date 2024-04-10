using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj3Controller: ControllerBase
    {
        [HttpGet()]
        public string[] Get([FromQuery] string[] words) 
        {
            var wordsQuery =
                from word in words
                where word[0] == 'b' && word[word.Length -1] == 'r'
                select word;

            
            return wordsQuery.ToArray();
        }
    }
}
