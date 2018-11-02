using Microsoft.AspNetCore.Mvc;

namespace BoardGame.Api.Controllers
{
    [Route("app")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class AppController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
