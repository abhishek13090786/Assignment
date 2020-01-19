using MVCFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilters.Controllers
{
    [CustAuthFilter]
    public class HomeController : Controller
    {
        [CustExceptionFilter]
        [CustomActionFilter]
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View();
        }


        [OutputCache(Duration = 10)]
        public ActionResult OutPutTest()
        {
            ViewBag.Date = DateTime.Now.ToString("T");
            return View();
        }

    }
}