using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CarOnline
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Index",
                url: "Trang-Chu",
                defaults: new { controller = "Main", action = "Index" }
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Main", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "CarOnline.Controllers" }
            );
            routes.MapRoute(
                name: "CarDetail",
                url: "{controller}/{chi-tiet}/{id}",
                defaults: new { controller = "CarDetail", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "CarOnline.Controllers" }
            );
        }
    }
}
