using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TechnoBergCMS.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            var sampleArticles = new { Title = "Blog article 1", Text = "This is a sample article in a anonymous type", Author = "Andy Bhadai", DateCreated = new DateTime(), Category = "Tech" };
            ViewData["data"] = sampleArticles;

            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
