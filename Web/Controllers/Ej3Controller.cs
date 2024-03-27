﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string name, [FromQuery] string age)
        {
            string nameAndAge = $"Te llamas {name} y tienes {age} años.";
            return nameAndAge;
        }
    }
}