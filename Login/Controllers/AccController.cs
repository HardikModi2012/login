using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Models;
using System.Web.Security;

namespace Login.Controllers
{
    public class AccController : Controller
    {
        // GET: Acc
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Membership model)
        {
            return View();
        }

        public ActionResult SignUp(User model)
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User model)
        {
            return View();
        }
        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("login","")
        }
    }
}