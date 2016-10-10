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
    public class ProductController : Controller
    {
        private readonly IProductRepository ProductRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.ProductRepository = productRepository;
        }

        public IActionResult Index()
        {
            var model = this.ProductRepository.GetAllProducts();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            // Check if the Blog-oject is valid (it uses the DataAnnotations in the Blog to validate the model)
            if (ModelState.IsValid)
            {
                this.ProductRepository.AddProduct(product);
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult View(int id)
        {
            var product = this.ProductRepository.Find(id);
            return View(product);
        }

        public IActionResult Edit(int id)
        {
            var product = this.ProductRepository.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            // Check if the Blog-oject is valid (it uses the DataAnnotations in the Blog to validate the model)
            if (ModelState.IsValid)
            {
                this.ProductRepository.Update(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }
    }
}
