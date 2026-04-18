using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CareQual_Tracker.Web.Pages.LoggedOut
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateUser(txtEmail.Text, txtPassword.Text))
            {
                FormsAuthentication.SetAuthCookie(txtEmail.Text, false);
                Response.Redirect("~/CareQual/Dashboard");
            }
            else
            {
                lblLoginError.Text = "Invalid login";
                pnlLoginError.Visible = true;
            }
        }

        private bool ValidateUser(string email, string password)
        {
            return email == "admin@admin.co.uk" && password == "password";
        }
    }
}