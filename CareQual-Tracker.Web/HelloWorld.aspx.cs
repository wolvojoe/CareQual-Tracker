using CareQual_Tracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CareQual_Tracker
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new CareQualTrackerDbContext())
            {
                Response.Write("EF works");
            }
        }
    }
}