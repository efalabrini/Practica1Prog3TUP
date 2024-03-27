﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : Controller
    {
        [HttpGet()]
        public string Get([FromQuery] string name, [FromQuery] string age) {
        string result = $"Te llamas {name} y tienes {age} anos";
        return result ;
        }
    }
}
