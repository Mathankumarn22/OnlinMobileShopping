using OnlineMobileShop.BL;
using OnlineMobileShop.Entity;
using OnlineMobileShop.Models;
using OnlineMobileShop.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineMobileShop.Controllers
{
    public class AccountController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(SignUp signUp)
        {
           
            if (ModelState.IsValid ) 
            {
               Account account =AutoMapper.Mapper.Map<Models.SignUp, Account>(signUp);
                account.Role = "User";
                bool result=AccountBL.SignUp(account);
                if(result)
                {
                    return RedirectToAction("LogIn");
                }                
            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(LogIn login)
        {
            if (ModelState.IsValid)
            {
                var log = AutoMapper.Mapper.Map<Models.LogIn, Account>(login);
                Account account = UserRespo.LogIn(log);
                if (account != null)
                {

                    FormsAuthentication.SetAuthCookie(account.MailID, false);
                    var authTicket = new FormsAuthenticationTicket(1, account.MailID, DateTime.Now, DateTime.Now.AddMinutes(20), false, account.Role);
                    string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                    var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                    HttpContext.Response.Cookies.Add(authCookie);
                }
            }
            return View();
        }
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Account");
        }
        public ActionResult DisplayUserDetails()
        {
            UserRespo userRespo = new UserRespo();
            List<Account> UserDetails = userRespo.GetUser();
            return View(UserDetails);
        }
    }   
}