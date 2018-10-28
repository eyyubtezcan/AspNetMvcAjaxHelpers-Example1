using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcAjaxHelpers_Example1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult LoadData()
        {
            List<string> veriler = new List<string>() { "İstanbul", "Balıkesir", "İzmir", "Muğla", "Antalya" };


            return PartialView("_VeriListesiPartialView", veriler);

        }
    }
}