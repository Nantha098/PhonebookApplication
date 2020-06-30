using PhonebookApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhonebookApplication.Controllers
{
    public class HomeController : Controller
    {
        static List<UserData> Phonebook = new List<UserData>();
        public ActionResult GoToHome()
        {
            return View("HomePage");
        }

        public ActionResult NewUser()
        {
            
            ViewBag.Message = "Enter the User Details";

            return View("UserDetails");
        }
       
        public ActionResult Save(UserData user)
        {
            Phonebook.Add(user);
            return View(Phonebook);

        }
    }
}