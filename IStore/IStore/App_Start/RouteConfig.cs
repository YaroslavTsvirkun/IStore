using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IStore
{
    /// <summary>
    /// Класс RouteConfig для работы и построения маршрутов приложения
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// Метод RegisterRoutes для работы с маршрутами приложения
        /// </summary>
        /// <param name="routes">Колекция маршрутов</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(name: "Default", url: "{language}/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }, 
                constraints: new { language = @"ru|en" },
                namespaces: new[] { "IStore.Controllers" });

            routes.MapRoute(name: "Language", url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, language = "ru" }, 
                namespaces: new[] { "IStore.Controllers" });
        }
    }
}
