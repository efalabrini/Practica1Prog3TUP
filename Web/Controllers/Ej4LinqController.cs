using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4LinqController : ControllerBase
    {
        [HttpGet()]
        public int[] Get([FromQuery] int[] numbers)
        {
            var selectedNumbers = numbers.OrderByDescending(x => x).Take(5).ToArray();
            return selectedNumbers;


        }
    }
}

