using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GR953500.Pages
{
    public class DemoModel : PageModel
    {
        public int Data { get; set; }


        [BindProperty]
        public int Id { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Data = Id;
            return Page();
        }
    }
}
