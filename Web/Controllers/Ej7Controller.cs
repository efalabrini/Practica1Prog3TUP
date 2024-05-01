﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7Controller : ControllerBase
    {
        [HttpGet()]
        public int Get()
        {
            int result = 0;

            for (int i = 1; i <= 100; i++)
            {
                result = i;
            }

            return result; // que retorne el ultimo numero para verificar que llego bien al resultado
        }
    }
}
