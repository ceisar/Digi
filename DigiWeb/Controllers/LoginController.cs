using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigiWeb.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Yonetici()
        {
            return View();
        }

        public ActionResult Kullanici()
        {
            return View();
        }

        public ActionResult Kaydol()
        {
            return View();
        }
    }
}