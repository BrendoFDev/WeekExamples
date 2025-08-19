using Microsoft.AspNetCore.Mvc;

namespace ThirdWeek.Controllers
{
    [Controller]
    [Route("/Api")]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index() => Ok("Requisição pelo controller");
    }
}
