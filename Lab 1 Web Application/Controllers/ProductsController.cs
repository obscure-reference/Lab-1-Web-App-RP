using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_1_Web_Application.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Products()
        {
         return View();
        }




        public ActionResult ProductReturned(string prod)
        {

         ViewBag.Prod = prod;
         return View();

        }

    }
}

