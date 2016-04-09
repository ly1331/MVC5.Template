﻿using System.Web.Mvc;
using System.Web.Routing;

namespace YZMIS.Controllers
{
    public class RouteConfig : IRouteConfig
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes
                .MapRoute(
                    "DefaultMultilingual",
                    "{language}/{controller}/{action}/{id}",
                    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                    new { language = "lt" },
                    new[] { "YZMIS.Controllers" })
                .DataTokens["UseNamespaceFallback"] = false;

            routes
                .MapRoute(
                    "Default",
                    "{controller}/{action}/{id}",
                    new { language = "en", controller = "Home", action = "Index", id = UrlParameter.Optional },
                    new { language = "en" },
                    new[] { "YZMIS.Controllers" })
                .DataTokens["UseNamespaceFallback"] = false;
        }
    }
}