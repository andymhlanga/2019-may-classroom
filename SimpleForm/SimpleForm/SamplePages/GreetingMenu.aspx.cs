using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleForm.SamplePages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private static List<Entry> contestentries = new List<Entry>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
        }

        protected void Submit_Registration(object sender, EventArgs e)
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
                    theEntry.UserName = UserName.Text;
                    theEntry.Password = Password.Text;

                    theEntry.EmailAddress = EmailAddress.Text;
                    theEntry.ConfirmEmail = ConfirmEmail.Text;
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


    }
}
