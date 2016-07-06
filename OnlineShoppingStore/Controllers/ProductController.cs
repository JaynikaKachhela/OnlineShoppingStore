using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingStore.Models;

namespace OnlineShoppingStore.Controllers
{
    public class ProductController : Controller
    {
        public ViewResult List()
        {
            Product product1 = new Product();
            product1.Name = "T-shirt";
            product1.Price = 300;
            product1.Description = "colored with blue, orange, red, yellow...";
                       
            return View(product1);
        }
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}