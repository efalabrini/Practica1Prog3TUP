using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7Controller : ControllerBase
    {
        [HttpGet()]
        public List<int> Get()
        {
           List<int> result = [];


           for (int i = 1; i <= 100; i++)
            {
                result.Add(i);
            }

            return (result);   
        }
    }
}
