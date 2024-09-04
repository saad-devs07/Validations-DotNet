using Microsoft.AspNetCore.Mvc;
using Validations.Data;
using Validations.Models;

namespace Validations.Controllers
{
    public class UserLoginController1 : Controller
    {
        ValidationsContext db;
        public UserLoginController1(ValidationsContext dbc)
        {
            db = dbc;
        }
       
        [HttpGet]
        public IActionResult UserCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserCreate(Login L)
        {
            db.Logins.Add(L);
            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public IActionResult ULogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ULogin(Login L)
        {
            var x = db.Logins.Where(a => a.Email == L.Email && a.Password == L.Password).FirstOrDefault();
            if (x != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.m = "Email and password are not matched";
                return View();
            }
           
        }
    }
}
