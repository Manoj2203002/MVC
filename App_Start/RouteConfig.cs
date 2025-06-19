using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");// Ignore Root
            //routes.MapRoute(
            //    name: "Page2",// Name Agrugemnts should be unique
            //    url: "Page_2",//URL Patten
            //    defaults: new { controller = "Routing", action = "Page2"}// Id us specifed as optional
            //);


            routes.MapRoute(
                name: "display",// Name Agrugemnts should be unique
                url: "display/{id}",//URL Patten
                constraints: new { id=@"\d{1,}" },// The Url Is resctrited to this formate
                defaults: new { controller = "Routing", action = "Display"}// Id us specifed dhould have one value
            );


            routes.MapMvcAttributeRoutes();// Enables the routing


            routes.MapRoute(
                name: "Default",// Name Agrugemnts should be unique
                url: "{controller}/{action}/{id}",//URL Patten
                defaults: new { controller = "MG", action = "Login", id = UrlParameter.Optional }// Id us specifed as optional
            );
        }
    }
}
