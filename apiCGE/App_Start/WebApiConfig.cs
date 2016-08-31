﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace apiCGE
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //JSON Formatında almak için gerekli
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            // Web API configuration and services
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
