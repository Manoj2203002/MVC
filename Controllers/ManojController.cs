using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ManojController : Controller
    {
        //the methord name and the view name are same
        // GET: Manoj
        public ViewResult Manoj()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View("Gayathri");// when ever the view and the methord name you can add it like this 
        }
        //View In the Shared Folder
        public ActionResult Light()
        {
            return View("MG");
        }
        //Display the View of Different Controller
        public ViewResult LightLight() {
            return View("~/Views/MG/Gaya.cshtml");
        }
        public ContentResult Ide() // Display only Content
        {
            return Content("Every this will be fine");
        }
        public String Ide2() // Another Way to Display Only Text
        {
            return "Good Man";
        }
        public int Add() // Returning Integer Value
        {
            int x = 6, y = 4, z = x + y;
            return z;
        }
        // Display the File In the Browser 
       public FileResult show()
        {
            return File (Server.MapPath("~/Content/MyFiles.txt"),"text/plain");
        }
        //Allow the User To Download the File 
        public FileResult Download()
        {
            return File(Server.MapPath("~/Content/MyFiles.txt"), "text/plain","My_Promise.txt");
        }
        // Redirecting The Result to the new URL

        // Internal URL which is belong to the webpage
        // This the internal url
       public RedirectResult ShowResult()
        {
            return Redirect("/Manoj/Manoj");
        }
        // External URl which belong to the Another Websites 
        // This is for External url
        public RedirectResult ShowResult2()
        {
            return Redirect("https://www.google.com/");
        }
        
        public ViewResult Contact()
        {
            return View("Contact");
            
        }
        public RedirectToRouteResult ShowContact()
        {
             return RedirectToRoute(new { Controller = "MG", Action = "Gaya" });// Redirect to another Controller
        }
        public RedirectToRouteResult Show2()
        {
            return RedirectToAction("Gaya","MG");
        }
        //Anonymous Type 
        // Dosen't have any name 
        // it Allows to Create Ovbject with new Keyword without defining its calss
        //The Implicity typd variabbles var is used to hold the reference of anonymous types 
        //it is accesable for only the current block of code;
        //Properties of anonymous type is only read only
        private void Anony()
        {
            var s1 = new
            {
                name = "Manoj",
                Age = 23,
            };
        }
        //Action Selector
        //Action Selector is the Attribure that can be applied to the action methords.
        // MVC The acction Selectors 1) Action Name,2)Non Action 3) ActionVerbs
        // Action Name --------
        // It allows you to specfiy a different action name than the methord name.
        //Non Action-------
        // Non Action Selectors attributes indicates that public methord of a controller is not an action methord.
        // Use Non action Attributes when you want to treate it an action methord.
        [ActionNameAttribute("aboutus")]
        public ViewResult About()
        {
            return View("About");
        }
        // Non Action 
        [NonAction]
        public string Greate()
        {
            return "Ïam the GOAT";
        }
        // Action Verbs -- The Action Verbs Selectors is used when you want to control the selection of an action based on a HTTP request methord.
        // For Example ,you can define toe different action methord the same name but one action methord reports to an HTTP Get request 
        //and another action methord responds to an HTTPPost request Here Methord Overloading rules are applicable
        // MVC framework supports different Action Verbs, Such as HTTPGET,HTTP Po,HHTPGet,HTTPset;
        [HttpPost] // only using form tage only
        public ViewResult About2() // Gefault it is get
        {
            return View("Äbout");
        }

        // Go to MgController to the next
        public ViewResult Ravi()
        {
            return View();
        }
    }

}