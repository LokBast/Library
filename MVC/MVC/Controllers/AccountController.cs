using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(LibraryEntities accout)
        {
            if (ModelState.IsValid)
            {
                using (OurDbContext db = new OurDbContext())
                {
                    db.userAccount.Add(accout);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = "Okay";
            }
            return View();
        }
        //Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LibraryEntities user)
        {
            using (OurDbContext db = new OurDbContext())
            {
                var usr = db.userAccount.Single()
            }
        }
    }
}