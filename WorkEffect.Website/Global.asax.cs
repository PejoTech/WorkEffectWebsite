using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WorkEffect.Website.App_Start;

namespace WorkEffect.Website
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // OWIN
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
