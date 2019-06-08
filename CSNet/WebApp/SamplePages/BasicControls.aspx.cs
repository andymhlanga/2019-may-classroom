using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class BasicControls : System.Web.UI.Page
    {

        //if you need to have a variable "hanging around
        //between postings then create a global static variable

        public static List<DDLClass> DataCollection = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            //THIS METHOD IS EXECUTED each and every time you process the web page 
            //this great for inital form setup
            //clearing old messages 

            //a control is refenced in the code code-behind by using its ID = name
            MessageLabel.Text = "";

            //page initalaztion only once during post back

            if (!Page.IsPostBack)
            {
                DataCollection = new List<DDLClass>();
                //Load collection using greedy constr
                DataCollection.Add(new DDLClass(1, "COMP108"));
                DataCollection.Add(new DDLClass(2, "CPSC1517"));
                DataCollection.Add(new DDLClass(4, "DMIT2018"));
                DataCollection.Add(new DDLClass(3, "DMIT1508"));


                //list of T can be sorted using .sort(delegate);
                //delegate syntax is 
                //Asceding sort
                //for   do the following 
                //(x,y) =>      x.PropertyName.CompareTo(y.PropertyName)

                //Desceding sort
                //for   do the following 
                //(x,y) =>      y.PropertyName.CompareTo(x.PropertyName)

                 DataCollection.Sort((x,y) => x.ValueField.CompareTo(y.ValueField));

                //attatch the data to the drop down list control
                //attach data
                CollectionList.DataSource = DataCollection;
                //assign the display text property to the ddl control HARD CODED

                CollectionList.DataTextField = "DisplayField";

                //assign the value data property to the ddl control OOP

                CollectionList.DataValueField = nameof(DDLClass.ValueField);

                //Bind the data to the control

                CollectionList.DataBind();

                //optionally add a prompt line

                CollectionList.Items.Insert(0, "SELECT.....");


            }
        }

        protected void SubmitChoice_Click(object sender, EventArgs e)
        {
            //Validate that a text box value was entered
            if (string.IsNullOrEmpty(TextBoxNumberChoice.Text))
            {

                MessageLabel.Text = "Enter a course number (1-4)";

            }
            else
            {


                //grab the value from the text box to set the radio button list 
                string numberchoice = TextBoxNumberChoice.Text;

                //use this value to set the check box
                //access techniques to a quote  "List" control
                //.SelectedValue gets / sets to the value field value
                //.SelectedIndex    get/sets to the control index value to check is choice was made 
                //.SelectedItem.Text   get the control display value
                RadioButtonListChoice.SelectedValue = numberchoice;

                //set a check box
                if(numberchoice.Equals("2") || numberchoice.Equals("4"))
                {
                    CheckBoxChoice.Checked = true;
                }
               


                // use this value to position inside the ddl
                CollectionList.SelectedValue = numberchoice;

                //use the various data access techniques to obtain diff values from the ddland display as a read only text

                DisplayReadOnly.Text = CollectionList.SelectedItem.Text + " at Index" + CollectionList.SelectedIndex + " has a value of " + CollectionList.SelectedValue;

            }

        }

        protected void LinkButtonSubmit_Click(object sender, EventArgs e)
        {
            //enter your code
        }

    }
}