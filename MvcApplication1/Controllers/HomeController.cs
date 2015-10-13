using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page. TESTADMDAOOSDas";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contsad A D ASact page. teste te te";

            return View();
        }
    }
}
