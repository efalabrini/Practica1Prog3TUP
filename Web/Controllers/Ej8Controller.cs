using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej8Controller : ControllerBase
    {
        [HttpGet()]
        public List<int> Get()
        {
            List<int> bucleNumbers= new List<int>();
            int i = 1;
            while (i <= 100)
            {
                bucleNumbers.Add(i);
                i++;
            }
            return bucleNumbers;
        }
    }
 }

