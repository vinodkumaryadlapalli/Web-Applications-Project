using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Test3
{
    // A to joke in Product model: They have big trunks.
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //Add the authorize filter to require the user to be logged in by default
            config.Filters.Add(new AuthorizeAttribute());
        }
    }
}
