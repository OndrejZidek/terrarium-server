﻿using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Terrarium.Server.DataModels;

namespace Terrarium.Server
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            //TODO uncomment this to get a new database created
            System.Data.Entity.Database.SetInitializer(new TerrariumDbSeedInitializer());
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
            MvcHandler.DisableMvcResponseHeader = true;
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ContainerConfig.RegisterContainers();
        }
    }
}