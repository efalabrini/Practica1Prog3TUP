using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej8Controller : ControllerBase
    {
        [HttpGet()]
        public List<int> Get()
        {
            List<int> num = [];
            int i = 0;
            while ( i <= 100)
            {
                num.Add(i);
                i++;
            }
            return num;
        }
    }
}