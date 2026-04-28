using CareQual_Tracker.Application.Administrator;
using CareQual_Tracker.Application.Administrator.Interfaces;
using CareQual_Tracker.Application.CareHomes.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CareQual_Tracker.Web.Pages.LoggedIn.CareHomes
{
    public partial class CareHomesList : Ninject.Web.PageBase
    {
        [Inject]
        public ICareHomeService CareHomeService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            gvCareHomes.DataSource = CareHomeService.GetAllCareHomes();
            gvCareHomes.DataBind();
        }


        protected void gvCareHomes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCareHomes.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.RedirectToRoute("CareHome");
        }



    }
}