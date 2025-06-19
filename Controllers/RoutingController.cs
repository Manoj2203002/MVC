using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    // Routing Approches 
    // Two Ways Traditional Routing/ Conventions Based Roution-- code based style of defining routes
    //Attribute Routing -- using declarative attributes on controller and action methord


    // Convention Based Routing 
    [RoutePrefix("admin")]// Conntoller level // Commen thing are comes here
    public class RoutingController : Controller
    {
        [Route("sigin_in")]// Attribure Level
        public ActionResult Page1()// Request Hander =Routing/Page1 
        {
            return View();
        }
        [Route("Page2")]
        public ActionResult Page2()
        {
            return View();
        }
        [Route("page3")]
        public ActionResult Page3()
        {
            return View();
        }
        public ActionResult Page4()
        {
            string message = "Hi How are you";
            ViewBag.M = message;
            return View();
        }
        public ContentResult Name(string name)
        {
            return Content(name);
        }
        public ContentResult Display(int id)
        {
            return Content(id.ToString());
        }

        // Attribute Routing -- in this approch declarative attributes on your controller class and action methord are used -- Enable Attribute Routing by calling the mapmvcattributeRoute 
        // registration methord in RouteConfig class.
        // Definging Attribute Routing -- Action Level --Controller Level

        // Action Level -- you have to definr the routes at action level which apply to a specfic action within the controller
        // Route attribute is used to specfiy route(URL Pattern)
        
    }
}