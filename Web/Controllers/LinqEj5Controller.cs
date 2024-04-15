using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Consulta5([FromQuery] List<int> numbers)
        {
            var result = numbers.Select(num => (num, square: num * num))
                                   .Where(tupla => tupla.square > 20)
                                   .Select(tupla => $"{tupla.num} - {tupla.square}")
                                   .ToList();
            return result;
        }
    }
}
