using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej9Controller : ControllerBase
    {
        [HttpGet()]
        public List<int> Get()
        {
            List<int> pairsNumber = new List<int>();
            
            for (int i = 1;i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    pairsNumber.Add(i);
                }
            }
            return pairsNumber;
        }
    }
}
