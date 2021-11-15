using Microsoft.AspNetCore.Mvc;

namespace GR953500.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show(int? id)
        {

            //RouteData.Values["month"]
            return View();
        }
    }
}
