using GR953500.Models;
using Microsoft.AspNetCore.Mvc;

namespace GR953500.Components
{
    public class RowViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(Book book)
        {
            return View(book);
        }

    }
}
