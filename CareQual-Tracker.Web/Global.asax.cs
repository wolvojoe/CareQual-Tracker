using Ninject;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace CareQual_Tracker.Web
{
    public class Global : NinjectHttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        protected override IKernel CreateKernel()
        {
            IKernel kernel = new StandardKernel(new NinjectBindings());
            return kernel;
        }


        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
                "Dashboard", "CareQual/Dashboard", "~/Pages/LoggedIn/Dashboard.aspx"
            );
            routes.MapPageRoute(
                "Login", "Login", "~/Pages/LoggedOut/Login.aspx"
            );
        }

    }
}