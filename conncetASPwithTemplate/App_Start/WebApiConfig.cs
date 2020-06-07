using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using conncetASPwithTemplate.Dtos;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
namespace conncetASPwithTemplate
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var settings = GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            settings.Formatting = Formatting.Indented;
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "PostAllModefiers",
            //    routeTemplate: "api/{controller}/{id}"
            //    //defaults: new { action = "PostModefiers", id = RouteParameter.Optional }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "PostAnItem",
            //    routeTemplate: "api/{controller}/{id}"
            //    //defaults: new { action = "PostItem", id = RouteParameter.Optional }
            //);


            config.Routes.MapHttpRoute(
                name: "DefaultApi",

                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
