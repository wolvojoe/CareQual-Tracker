using CareQual_Tracker.Application.CareStaff.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CareQual_Tracker.Web.Pages.LoggedIn.Staff
{
    public partial class StaffList : Ninject.Web.PageBase
    {
        [Inject]
        public IStaffService StaffService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            gvCareStaff.DataSource = StaffService.GetAllStaff();
            gvCareStaff.DataBind();
        }


        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.RedirectToRoute("CareStaff");
        }

        protected void gvCareStaff_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCareStaff.PageIndex = e.NewPageIndex;
            BindGrid();
        }
    }
}