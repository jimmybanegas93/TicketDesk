﻿using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicketDesk.Web.Client.Startup))]
namespace TicketDesk.Web.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AreaRegistration.RegisterAllAreas();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            RegisterBundles(BundleTable.Bundles);

            ConfigureDatabase();
            ConfigureAuth(app);
        }
    }
}