using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SalesSystem.Controllers
{
    [AllowAnonymous]
     public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if(username=="user" && password=="user")
            {
                FormsAuthentication.SetAuthCookie(username, false);
                FormsAuthentication.RedirectFromLoginPage(username, false);
                //Session["id"] = username;
            }
            
                return View();
             
          
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}