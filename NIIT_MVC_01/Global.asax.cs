using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MyPlaces.Models;
using System.Web.Http.WebHost;
using System.Web.Http;

namespace MyPlaces
{    
        public class MvcApplication : System.Web.HttpApplication
        {
            public static List<Place> Places = new List<Place>();

            protected void Application_Start()
            {
                AreaRegistration.RegisterAllAreas();
                MyPlaces.App_Start.WebApiConfig.Register(GlobalConfiguration.Configuration);
                //MyPlaces.App_Start.WebApiConfig.Register(GlobalConfiguration.Configuration);
                //GlobalConfiguration.Configure(MyPlaces.App_Start.WebApiConfig.Register);
                FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
                RouteConfig.RegisterRoutes(RouteTable.Routes);
                BundleConfig.RegisterBundles(BundleTable.Bundles);

            }
        }
        
}
