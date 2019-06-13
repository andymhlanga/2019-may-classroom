using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ContestEntry : System.Web.UI.Page
    {

        //Since we are not using a data baseto hold the data we will use a page level static variable to hold the data
        //The data will be described in the class entry
        //the collection will be a list of T where T is entry

        private static List<Entry> contestentries = new List<Entry>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //The client side validation in the browser done by the validation controls can be reexecuted on the server

            if (Page.IsValid)

            {
                //if you have logical validation or buisness rules to check they can now be done
                //We have a buisness rules that says terms must be checked

                if (Terms.Checked)
                {
                    //accept entry
                    //create an instance of the entry
                    Entry theEntry = new Entry();
                    theEntry.FirstName = FirstName.Text;
                    theEntry.LastName = LastName.Text;
                    theEntry.StreetAddress1 = StreetAddress1.Text;
                    theEntry.StreetAddress2 = String.IsNullOrEmpty(StreetAddress2.Text)? null : StreetAddress2.Text;
                    theEntry.City = City.Text;
                    theEntry.PostalCode = PostalCode.Text;
                    theEntry.EmailAddress = EmailAddress.Text;
                    theEntry.Province = Province.SelectedValue;
                    theEntry.FirstName = FirstName.Text;

                    //Added  data to the instance
                    contestentries.Add(theEntry);


                    //dispaly the list of entries to the grid view
                    EntriesList.DataSource = contestentries;
                    EntriesList.DataBind();

                }
                else
                {
                    //reject entry
                    Message.Text = "You did not agree to the contest terms entry rejected.";
                }

            }





        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            PostalCode.Text = "";
            EmailAddress.Text = "";
            CheckAnswer.Text = "";
            City.Text = "";
            Province.SelectedIndex = 0;
            Terms.Checked = false;
        }
    }
}