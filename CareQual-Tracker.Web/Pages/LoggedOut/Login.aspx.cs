using CareQual_Tracker.Application.Authentication;
using CareQual_Tracker.Application.Authentication.Interfaces;
using Ninject;
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
    public partial class Login : Ninject.Web.PageBase
    {
        [Inject]
        public ICareQualUserAuthService CareQualUserAuthService { get; set; }


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

        private bool ValidateUser(string emailAddress, string password)
        {
            return CareQualUserAuthService.Login(emailAddress, password);
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var user = CareQualUserAuthService.Register(txtEmail.Text, txtPassword.Text);
                FormsAuthentication.SetAuthCookie(user.EmailAddress, false);
                Response.Redirect("~/CareQual/Dashboard");
            }
            catch (Exception ex)
            {
                lblLoginError.Text = ex.Message;
                pnlLoginError.Visible = true;
            }
        }
    }
}