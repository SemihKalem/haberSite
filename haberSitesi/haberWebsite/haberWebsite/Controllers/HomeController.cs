using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace haberWebsite.Controllers
{
    public class HomeController : Controller
    {

        HaberContext db = new HaberContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SliderGetir()
        {
            return View();
        }

        public ActionResult EnSonHaberler()
        {
            return View();
        }

        public ActionResult UstTab()
        {
            return View();
        }

    }
}
