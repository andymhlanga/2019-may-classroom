using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindApp.SamplePages
{
    public partial class ODS_Reviewed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
        }

        protected void ProductFetch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(ProductNameArg.Text))
            {
                MessageLabel.Text = "Enter a partial product name ";
            }
        }
    }
}