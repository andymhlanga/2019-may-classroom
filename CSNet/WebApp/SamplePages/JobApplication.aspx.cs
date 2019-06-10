using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class JobApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //clear out all old messages 
            MessageLabel.Text = "";


        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string msg = "";
            msg += "Name  = " + FullName.Text;
            msg += "Email  = " + Email.Text;
            msg += "Phone  = " + PhoneNumber.Text;
            msg += "Time:  = " + (FullOrPartTime.SelectedValue.Equals("1")?"Full Time (1)":"Part Time (2)");

            msg += " Jobs =";
            bool found = false;
            foreach (ListItem jobrow in Jobs.Items)
            {
                if (jobrow.Selected)
                {
                    msg += jobrow.Text + " ";
                    found = true;
                }

            }
            if (!found)
            {
                msg += "You did not select a job application rejected";

            }

            MessageLabel.Text = msg;
        }

        protected void Clear_Click(object sender, EventArgs e)
        {

            //empt all text boxes and remove radio button and checkbox choices
            //the ID you gave your control is your variable is your variable in your coding
            //remember objects and setting property 
            FullName.Text = "";
            Email.Text = "";
            PhoneNumber.Text = "";
            //One technique to reset the radio button list is to set the index to a non existent list to -1
            FullOrPartTime.SelectedIndex = -1;

            //a second technique to reset the radion buttons is to use a method of the object call clear selection

            Jobs.ClearSelection();


            
        }
    }
}