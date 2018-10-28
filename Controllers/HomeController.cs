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
            List<string> veriler = new List<string>() { "İstanbul", "Balıkesir", "İzmir", "Muğla", "Antalya" };
            Session["listem"] = veriler;

            return View();
        }
        public PartialViewResult LoadData()
        {
            List<string> veriler = Session["listem"] as List<string>;
            System.Threading.Thread.Sleep(3000);
            return PartialView("_VeriListesiPartialView", veriler);

        }

        public MvcHtmlString RemoveData(int id)
        {
            List<string> veriler = Session["listem"] as List<string>;
            veriler.RemoveAt(id);
            Session["Listem"] = veriler;
            System.Threading.Thread.Sleep(3000);
            return MvcHtmlString.Empty;

        }
    }
}