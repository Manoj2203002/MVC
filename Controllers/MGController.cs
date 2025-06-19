using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MGController : Controller
    {
        // GET: MG
        public ActionResult Gaya() // Action Methord
        {
            return View();
        }
        public ActionResult Green()
        {
            return View();
        }
        // Collecting Request Values in Action Methords.
        // Traditional Methord 
        // Model Binding 

        // Traditional methord -- Now in traditional methord we use traditional way to get the http values int he action methord are
        //-- Data Collection
        //-- Request Quesy String For HTTP Get request.
        //-- Request (RequestFrom)For HTTP POST request.
        //--You ca also include Form Collection type parameter in the action methord insted of complex type,to retrive all the value from view from fields

        public ActionResult List()
        {
            return View();
        }

        //Requwst Data Collection 
        //public ContentResult Detials()
        //{
        //    string x =(Request["Name"]);
        //    string county = "";
        //    switch(x)
        //    {
        //        case "Manoj": county = "TN"; break;
        //        case "Gayathri": county = "TN"; break;
        //        case "Priya": county = "KA"; break;
        //    }
        //    return Content(county);
        //}


        // Requtest.Query String---------------
        //public ContentResult Detials()
        //{
        //    String x = Request.QueryString["Name"];
        //    string county = "";
        //    switch (x)
        //    {
        //        case "Manoj": county = "TN"; break;
        //        case "Gayathri": county = "TN"; break;
        //        case "Priya": county = "KA"; break;
        //    }
        //    return Content(county);
        //}

        // How To Collect the Data from Post
        public ViewResult login()
        {
            return View();
        }
        //[HttpPost]
        //public ContentResult Valid()
        //{
        //    string s = Request["Name"];
        //    string p = Request["password"];
        //    if (s=="Manoj" && p=="Gayathri")
        //    {
        //        return Content("Welcome");
        //    }
        //    else
        //    {
        //        return Content("Sorry");
        //    }
        //}
        //public ContentResult Valid(FormCollection values)
        //{
        //    string s = values["Name"];
        //    string p = values["password"];
        //    if (s == "Manoj" && p == "Gayathri")
        //    {
        //        return Content("Welcome");
        //    }
        //    else
        //    {
        //        return Content("Sorry");
        //    }
        //}
        // Action methord Parameters
        // Took The Screen Short


        //Model Binding -- With Model binding MVC framework converts  the http request values(from query string or form collection) to action methord parameters.
        // Two Types -- Premitive And Complex

        //-- Premitive
        public ContentResult Detials(string Name)
        {
            string county = "";
            switch (Name)
            {
                case "Manoj": county = "TN"; break;
                case "Gayathri": county = "TN"; break;
                case "Priya": county = "KA"; break;
            }
            return Content(county);
        }
        //Post Methord using Model Binding
        public ContentResult Valid(string Name,string password)
        {
          
            if (Name == "Manoj" && password == "Gayathri")
            {
                return Content("Welcome");
            }
            else
            {
                return Content("Sorry");
            }
        }
        // Overloading in Action Methord--cant able to overload action--becouse controller is not normal class it use https that is the reason
        // Overloading of action are possible with
        // Using different HTTp Verbs 
        // Use Non Action Attributes
        // Use Action Attributes
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ContentResult Register(string name, string email, string Pass, string confpas)
        {
            if (Pass == confpas)
            {
                return Content("Registerd Succesfully");
            }
            else
            {
                return Content("Wrong Password");
            }
        }
        // Routing in the Routingcontrollr
    }
}