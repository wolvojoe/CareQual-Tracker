using CareQual_Tracker.Application.Administrator.Interfaces;
using CareQual_Tracker.ViewModels.ViewModels;
using Ninject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CareQual_Tracker.Web.Pages.LoggedIn.Administration
{
    public partial class QualificationsList : Ninject.Web.PageBase
    {
        [Inject]
        public IQualificationService QualificationService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            gvQualifications.DataSource = QualificationService.GetAllQualifications();
            gvQualifications.DataBind();
        }

        protected void gvQualifications_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvQualifications.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.RedirectToRoute("Qualification");
        }

        protected void lbtnDelete_Command(object sender, CommandEventArgs e)
        {
            QualificationService.DeleteQualification(Convert.ToInt32(e.CommandArgument));
            BindGrid();
        }
    }
}