using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CareQual_Tracker.Web.MasterPages
{
    public partial class LoggedIn : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Abandon();

            Response.Redirect(GetRouteUrl("Login", null));
        }

    }
}