using Microsoft.AspNetCore.Mvc;

namespace GR953500.Areas.Demo.Controllers
{
    [Area("Demo")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
