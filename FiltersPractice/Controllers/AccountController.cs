using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FiltersPractice.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        [Obsolete]
        public ActionResult Login(string username, string password, string returnUrl)
        {
            bool result = FormsAuthentication.Authenticate(username, password);
            if (result)
            {
                FormsAuthentication.SetAuthCookie(username, false);
                return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
            }
            else
            {
                ModelState.AddModelError("", "Incorrect username or password");
                return View();
            }
        }

        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}