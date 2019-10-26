using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(Data data)
        {
            if(ModelState.IsValid){
                return View("Thanks", data);
            }
            else
            {
                return View();
            }
        }

    }
}