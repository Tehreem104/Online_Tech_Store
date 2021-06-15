using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult SignUP()
        {
            return View();
        }

        public ActionResult SignIN()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Sign_up(string Name,string Email,string Password )
        {
            if (Class1.SIGN_UP(Name, Email, Password))
                return View("SignIN");
            else
                return View("Failed");
        }
       public ActionResult Sign_In(string email,string Password)
        {
            if (Class1.SIGN_IN(email, Password))
                return View("Main");
            else
                return View("Failed");
        }
        public ActionResult CheckOut()
        {
                return View();   
        }
        public ActionResult Main()
        {
            return View("Main");
        }
        public ActionResult Product1()
        {
            if (Class1.AddToCart(" Audio-Technica HeadPhones"))
            {
                return View("CheckOut");

            }
            else
                return View("Failed");
        }
        public ActionResult Product2()
        {
            if (Class1.AddToCart("Dell core i7 pro"))
            {
                return View("CheckOut"); ;
            }
            else
                return View("Failed");
        }
        public ActionResult Product3()
        {
            if (Class1.AddToCart("Hp 250 G7 Notebook"))
            {
                return View("CheckOut"); ;
            }
            else
                return View("Failed");
        }

        public ActionResult Product4()
        {
            if (Class1.AddToCart("Xperia Z4 Tablet"))
            {
                return View("CheckOut"); ;
            }
            else
                return View("Failed");
        }
        public ActionResult Product5()
        {
            if (Class1.AddToCart("HP ZBook 17 G6"))
            {
                return View("CheckOut"); ;
            }
            else
                return View("Failed");
        }
        public ActionResult Product6()
        {
            if (Class1.AddToCart("Sony Over-Ear Headphones"))
            {
                return View("CheckOut"); ;
            }
            else
                return View("Failed");
        }
        public ActionResult Product7()
        {
            if (Class1.AddToCart("MSI GS75 STEALTH-1243"))
            {
                return View("CheckOut"); ;
            }
            else
                return View("Failed");
        }

        public ActionResult Product8()
        {
            if (Class1.AddToCart("Samsung Galaxy M21 "))
            {
                return View("CheckOut"); ;
            }
            else
                return View("Failed");
        }
        public ActionResult Product9()
        {
            if (Class1.AddToCart("Acer laptop A7S "))
            {
                return View("CheckOut"); ;
            }
            else
                return View("Failed");
        }
        public ActionResult Product10()
        {
            if (Class1.AddToCart("REKAM Digital Camera"))
            {
                return View("CheckOut"); ;
            }
            else
                return View("Failed");
        }
        public ActionResult Laptops()
        {
           
                return View("Laptops"); ;
            
        }
        public ActionResult Smartphones()
        {

            return View("Smartphones"); ;

        }

        public ActionResult Cameras()
        {

            return View("Cameras"); ;

        }
        public ActionResult Accessories()
        {

            return View("Accessories"); ;

        }

        public ActionResult HotDeals()
        {

            return View("HotDeals"); ;

        }

    }

}


