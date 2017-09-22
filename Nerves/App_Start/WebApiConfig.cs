using Nerves.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace Nerves
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //config.
            // Web API configuration and services
            //config.Filters.Add(new Filters.NotImplExceptionFilterAttribute());

            //config.Services.Replace(typeof(IExceptionHandler), new NervesExceptionHandler());
            //config.Services.Add(typeof(IExceptionLogger), new NervesExceptionLogger());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional },
                constraints: new { id = @"\d+" }
            );
        }
    }
}
