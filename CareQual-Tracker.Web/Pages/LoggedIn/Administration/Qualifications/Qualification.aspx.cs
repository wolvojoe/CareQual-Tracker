using System;
using Ninject;
using CareQual_Tracker.Application.Administrator.Interfaces;
using CareQual_Tracker.ViewModels.ViewModels;

namespace CareQual_Tracker.Web.Pages.LoggedIn.Administration.Qualifications
{
    public partial class Qualification : Ninject.Web.PageBase
    {
        [Inject]
        public IQualificationService QualificationService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadQualification();
            }
        }

        private void LoadQualification()
        {
            if (QualificationService == null) return;

            var idValue = Request.QueryString["id"];
            if (int.TryParse(idValue, out int id) && id > 0)
            {
                var vm = QualificationService.GetQualificationById(id);
                if (vm != null)
                {
                    hfQualificationId.Value = vm.QualificationId.ToString();
                    txtName.Text = vm.Name;
                    txtAwardingBody.Text = vm.AwardingBody;
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            int.TryParse(hfQualificationId.Value, out int id);

            var vm = new QualificationViewModel
            {
                QualificationId = id,
                Name = txtName.Text?.Trim(),
                AwardingBody = txtAwardingBody.Text?.Trim()
            };

            if (id == 0)
            {
                QualificationService.CreateQualification(vm);
            }
            else
            {
                QualificationService.UpdateQualification(vm);
            }

            Response.RedirectToRoute("Qualifications");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.RedirectToRoute("Qualifications");
        }
    }
}