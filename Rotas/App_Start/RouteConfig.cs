using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rotas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Todas as Noticias",
                url: "TodasNoticias/",
                defaults: new { controller = "Home", action = "TodasAsNoticias" }
            );

            routes.MapRoute(
                name: "Noticias por Categoria",
                url: "Noticias/{categoria}/",
                defaults: new { controller = "Home", action = "MostraCategoria" }
            );

            routes.MapRoute(
                name: "Noticias",
                url: "Noticia/{categoria}/{titulo}",
                defaults: new { controller = "Home", action = "MostraNoticia" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
