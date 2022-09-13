using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCWCF.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        DemoService.Service1Client ser = new DemoService.Service1Client();
        DemoService.vlogin vlogin = new DemoService.vlogin();
        DemoService.UserRegister1 UserRegister1 = new DemoService.UserRegister1();
        
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(DemoService.vlogin vlog)
        {
            string check = ser.UserLogin(vlog);
            if (check == "true")
            {
                Session["Username"] = vlog.UserName.ToString();
                return RedirectToAction("User", "Login");
            }
            else
            {
                TempData["error"] = "<script> alert('Incorrect Usrename or Password... Please try again')</script>";
                return View();
            }
        }
        public ActionResult User()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(DemoService.UserRegister1 UserRegister1 )
        {

            string check = ser.RegisterInsert(UserRegister1);
            if (check == "true")
            {
                Session["Username"] = UserRegister1.UserName.ToString();
                return RedirectToAction("User", "Login");
            }
            else
            {
                TempData["error"] = "<script> alert('Incorrect Usrename or Password... Please try again')</script>";
                return View();
            }
           
        }


        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }


        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }





























    }


}