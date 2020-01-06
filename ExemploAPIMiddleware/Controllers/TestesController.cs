using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ExemploAPIMiddleware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "ASP.NET Core 3.1", "Teste com Middleware Customizado"};
        }
    }
}