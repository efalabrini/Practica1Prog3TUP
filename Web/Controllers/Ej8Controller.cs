using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej8Controller: ControllerBase
    {
        [HttpGet()]
        public List<int> Get() { 
            List <int> list = new List<int>();
            int x = 1;
            while (x < 101) {
                list.Add(x);
                x++;
            }
            return list;
        
        }
        
    }
}



