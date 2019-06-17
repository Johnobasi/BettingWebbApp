using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BettingWebbApp.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Betting", action = "List", id = UrlParameter.Optional }
            );

            routes.MapRoute(null, "",
                new
                {
                    controller = "Betting",
                    action = "List",
                    category = (string)null,
                });
          
            
        }
    }
}
