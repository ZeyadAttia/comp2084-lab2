using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string categoryName) {
            // it will be null only if the user entered this link (GET: Categories/Details) directly in the url and without the required parameters as a query string, not using the provided links.
            if (categoryName != null) {
                ViewBag.CategoryNameMessage = "You selected category: " + categoryName;
            }
            return View();
        }
    }
}