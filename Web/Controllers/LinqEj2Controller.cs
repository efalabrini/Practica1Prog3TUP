using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LinqEj2Controller : ControllerBase
{
    [HttpGet()]
    public string[] Get([FromQuery] List<string> lista)
    {
        var query = 
            from palabra in lista
            where palabra.Length >= 5
            select palabra.ToUpper();

        return query.ToArray();
    }
}