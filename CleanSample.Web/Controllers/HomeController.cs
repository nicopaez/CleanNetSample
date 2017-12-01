using Castle.Core.Logging;
using CleanSample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CleanSample.Web.Controllers
{
    public class HomeController : Controller
    {
        public IFoo Foo { get; set; }

        public ILogger Logger { get; set; }

        public ActionResult Index()
        {
            this.Logger.Info("homeController index invoked");
            this.Foo.DoFoo();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}