using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LingqEj1Controller : ControllerBase
{
    [HttpGet()]
    public int[] Get([FromQuery] List<int> lista)
    {
        var query = 
            from num in lista
            where num > 30 && num < 100
            select num;

        return query.ToArray();
    }
}
   