﻿namespace MVC.Essetials.Web
{
    using System.Data.Entity;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using Data;
    using Data.Migrations;

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            ViewEnginesConfig.RegisterViewEngines(ViewEngines.Engines);
            AutofacConfig.RegisterAutofac();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
