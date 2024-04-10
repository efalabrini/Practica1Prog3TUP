using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.RegularExpressions;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj6Controller : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> words)
        {
            var result =
                from word in words
                select Regex.Replace(word, "ia", "*");
                

            return result.ToList();
        }
    }
}