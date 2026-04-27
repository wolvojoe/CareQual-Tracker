using Ninject;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace CareQual_Tracker.Web
{
    public class Global : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();


            ScriptManager.ScriptResourceMapping.AddDefinition("jquery",
                new ScriptResourceDefinition
                {
                    Path = "~/Scripts/jquery-3.6.0.min.js",
                    DebugPath = "~/Scripts/jquery-3.6.0.js",
                    CdnPath = "https://code.jquery.com/jquery-3.6.0.min.js",
                    CdnDebugPath = "https://code.jquery.com/jquery-3.6.0.js",
                    CdnSupportsSecureConnection = true
                });

            RegisterRoutes(RouteTable.Routes);
        }

        protected override IKernel CreateKernel()
        {
            IKernel kernel = new StandardKernel(new NinjectBindings());
            return kernel;
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("Default", "", "~/Pages/LoggedOut/Login.aspx");
            routes.MapPageRoute("Login", "Login", "~/Pages/LoggedOut/Login.aspx");
            routes.MapPageRoute("Dashboard", "CareQual/Dashboard", "~/Pages/LoggedIn/Dashboard.aspx");
            routes.MapPageRoute("Qualifications", "CareQual/Qualifications/List", "~/Pages/LoggedIn/Administration/Qualifications/List.aspx");
            routes.MapPageRoute("Qualification", "CareQual/Qualifications/Details", "~/Pages/LoggedIn/Administration/Qualifications/Qualification.aspx");
        }
    }
}