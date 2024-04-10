using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj5Controller : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] int[] inputList)
        {
            var result = (from num in inputList
                  let square = num * num
                  where square > 20
                  select $"{num}-{square}").ToList();

            return result;
        }
    }
}