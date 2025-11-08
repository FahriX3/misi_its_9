using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("halo")]
        public string Index()
        {
            return "hello selamat pagi";
        }

        [HttpGet("test")]
        public string nama([FromQuery] string nama)
        {
            return "hello, " + nama ;
        }
    }
}
