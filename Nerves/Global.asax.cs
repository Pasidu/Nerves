using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Nerves
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(AutofacConfig.Register);
            GlobalConfiguration.Configure(WebApiConfig.Register);

           
        }
    }
}
