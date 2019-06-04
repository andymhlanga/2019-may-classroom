using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class Hello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageArea.Text = "what ever I want";
        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            MessageArea.Text = "";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            MessageArea.Text = "Andiswa Mhlanga";
        }
    }
}