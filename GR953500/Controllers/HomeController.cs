using GR953500.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace GR953500.Controllers
{    
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<Book> books;
        public HomeController(ILogger<HomeController> logger)
        {
            
            books = new List<Book>
            {
                new Book{ BookId=1, Name="Book1", Author="Author1"},
                new Book{ BookId=2, Name="Book2", Author="Author2"},
                new Book{ BookId=3, Name="Book3", Author="Author2"}
            };
            _logger = logger;
        }

        public IActionResult ShowBooks()
        {
            return View(books);
        }

        public IActionResult UserInfo(int id)
        {
            return View();
        }
        public IActionResult Index()
        {

            ViewBag.Name = "Bob";
            ViewData["books"] = new SelectList(books,"BookId","Name");
            return View(books);
        }
        [AllowAnonymous]
        public IActionResult LayoutDemo()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
