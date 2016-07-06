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

        private ProductDbContext db = new ProductDbContext();
             
            public ViewResult List()
            {          
                 return View(db.Products.ToList());
             }
    }
}