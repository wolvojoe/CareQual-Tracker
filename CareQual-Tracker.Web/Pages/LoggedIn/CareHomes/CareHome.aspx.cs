using CareQual_Tracker.Application.Administrator;
using CareQual_Tracker.Application.CareHomes.Interfaces;
using CareQual_Tracker.ViewModels.ViewModels;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CareQual_Tracker.Web.Pages.LoggedIn.CareHomes
{
    public partial class CareHome : Ninject.Web.PageBase
    {
        [Inject]
        public ICareHomeService CareHomeService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCareHome();
            }
        }

        private void LoadCareHome()
        {
            if (CareHomeService == null) return;

            var idValue = Request.QueryString["id"];
            if (int.TryParse(idValue, out int id) && id > 0)
            {
                var vm = CareHomeService.GetCareHomeById(id);
                if (vm != null)
                {
                    hfCareHomeId.Value = vm.CareHomeId.ToString();
                    txtName.Text = vm.CareHomeName;
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            int.TryParse(hfCareHomeId.Value, out int id);

            var vm = new CareHomeViewModel
            {
                CareHomeId = id,
                CareHomeName = txtName.Text?.Trim()
            };

            if (id == 0)
            {
                CareHomeService.CreateCareHome(vm);
            }
            else
            {
                CareHomeService.UpdateCareHome(vm);
            }

            Response.RedirectToRoute("CareHomes");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.RedirectToRoute("CareHomes");
        }
    }
}