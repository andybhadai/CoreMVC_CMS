using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnoBergCMS.Services;
using TechnoBergCMS.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TechnoBergCMS.Controllers
{
    public class BlogController : Controller
    {
        // No operations on this list
        private readonly IBlogRepository BlogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            this.BlogRepository = blogRepository;
        }

        public IActionResult Index()
        {
            var model = this.BlogRepository.GetAllBlogs();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            // Check if the Blog-oject is valid (it uses the DataAnnotations in the Blog to validate the model)
            if (ModelState.IsValid)
            {
                this.BlogRepository.AddBlog(blog);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
