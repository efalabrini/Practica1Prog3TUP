using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej9Controller : ControllerBase
    {
        [HttpGet()]
        public List<int> Get()
        {
            List<int> num = [];
            int i = 0;
            while (i <= 100)
            {
                if (i%2 == 0)
                {
                    num.Add(i);
                    i++;
                }
                else
                {
                    i++;
                }
            }
            return num;
        }
    }
}