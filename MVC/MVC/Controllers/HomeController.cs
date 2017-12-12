using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        LibraryEntities db = new LibraryEntities();
        public ActionResult Index()
        {        
            ViewBag.Books = db.Book;
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        //[Authorize (Users = "user")]
        public ActionResult Reserve()
        {
            //ViewBag.Books = db.Book;
            return View();
        }
    }
}