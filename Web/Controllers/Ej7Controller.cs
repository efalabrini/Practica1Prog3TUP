using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej7Controller : ControllerBase
    {
        [HttpGet]
        public int Get() 
        {
            int result = 0;
            for(int i = 0; i < 101; i++)
            {
                result = i;
            }

            return result;
        }
    }
}
