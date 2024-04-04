using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7Controller : ControllerBase
    {
        [HttpGet()]
        public List<int> Get()
        {
            List<int> myList = new List<int>(); 
            
            for(int i = 1; i < 101; i++) { 
                myList.Add(i);
            }
            return myList;
        }

            

    }
}


