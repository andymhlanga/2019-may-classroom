<%@ Page Title="Grreting Menu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GreetingMenu.aspx.cs" Inherits="SimpleForm.SamplePages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

          <div class="page-header">
        <h1>User Regitration</h1>
    </div>

    <div class="row col-md-12">
        <div class="alert alert-info">
            <blockquote style="font-style: italic">
              Please fill out form below and click submit. After submitting the form you will receivve an email with a link to confirm your registration By clicking that link, you will complete the registration process 
            </blockquote>
      

        </div>
    </div>
 <%-- Validation Controls --%>
    <%-- Rules:
        a) any control can have 1 or more validation controls
        b) a control may have only one instance of a particular
            type of validation control 
        c) errors messages from the validation control can
            be placed in a summary display and/or beside the
            input control
        d) validation controls within a fieldset using Bootwrap
            do NOT format well
        e) validation controls have certain common parameters
            and then their specific set of parameters
        f) this is c# thus case sensitivity and spelling is important--%>
    <asp:RequiredFieldValidator ID="RequiredFirstName" runat="server"
        ErrorMessage="First Name is required" Display="None" 
         SetFocusOnError="true" ForeColor="Firebrick" 
        ControlToValidate="FirstName"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredLastName" runat="server"
        ErrorMessage="Last Name is required" Display="None" 
         SetFocusOnError="true" ForeColor="Firebrick" 
        ControlToValidate="LastName"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredUserName" runat="server"
        ErrorMessage="User Name is required" Display="None" 
         SetFocusOnError="true" ForeColor="Firebrick" 
        ControlToValidate="UserName"></asp:RequiredFieldValidator>

    <asp:RegularExpressionValidator ID="RegExpEmailAddress" runat="server" ErrorMessage="Invalid email address" Display="None"
         SetFocusOnError="true" ForeColor="Firebrick"
         ControlToValidate="EmailAddress" 
         ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"></asp:RegularExpressionValidator>

      <asp:RegularExpressionValidator ID="RegularExpConfirmEmail" runat="server" ErrorMessage="Invalid email address" Display="None"
         SetFocusOnError="true" ForeColor="Firebrick"
         ControlToValidate="ConfirmEmail" 
         ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"></asp:RegularExpressionValidator>

    
      <asp:RegularExpressionValidator ID="RegularExpPassword" runat="server" ErrorMessage="Invalid password must be between 4 and 8 digits incl one numeric digit" Display="None"
         SetFocusOnError="true" ForeColor="Firebrick"
         ControlToValidate="Password" 
         ValidationExpression="^(?=.*\d).{4,8}$"></asp:RegularExpressionValidator>
       
      <asp:RegularExpressionValidator ID="RegularExpConfirmPassword" runat="server" ErrorMessage="Invalid password must be between 4 and 8 digits incl one numeric digit" Display="None"
         SetFocusOnError="true" ForeColor="Firebrick"
         ControlToValidate="ConfirmPassword" 
         ValidationExpression="^(?=.*\d).{4,8}$"></asp:RegularExpressionValidator>


  
    <%-- Compare validator has 3 versions 
        a) datatype parameters type and operator
        b) against a constant parameters type, operator and value
        c) against another form control parameters type, operator and controltocompare --%>
   
    <asp:CompareValidator runat="server" id="CompareEmails" 
        controltovalidate="EmailAddress" controltocompare="ConfirmEmail"
        operator="Equal" type="String" 
        errormessage="The email addresses do not match!" /><br />

    <asp:CompareValidator runat="server" id="ComparePasswords" 
        controltovalidate="Password" controltocompare="ConfirmPassword"
        operator="Equal" type="String" 
        errormessage="The passwords you typed do not match!" /><br />

<%-- Validation error Display --%>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Correct the input for the following errors:"
         CssClass="alert alert-warning"/>

    <div class="row">
        <div class ="col-md-6">
            <fieldset class="form-horizontal">
                <legend>Application Form</legend>

                <asp:Label ID="Label1" runat="server" Text="First Name"
                     AssociatedControlID="FirstName"></asp:Label>
                <asp:TextBox ID="FirstName" runat="server" 
                    ToolTip="Enter your first name." MaxLength="25"></asp:TextBox> 
                  
                 <asp:Label ID="Label6" runat="server" Text="Last Name"
                     AssociatedControlID="LastName"></asp:Label>
                <asp:TextBox ID="LastName" runat="server" 
                    ToolTip="Enter your last name." MaxLength="25"></asp:TextBox> 
                        
                <asp:Label ID="Label3" runat="server" Text="User Name"
                     AssociatedControlID="UserName"></asp:Label>
                <asp:TextBox ID="UserName" runat="server" 
                    ToolTip="Enter your User name." MaxLength="75"></asp:TextBox> 
     
                 <%-- TextMode is Html5 restriction which executes
                     prior to any Validation Control--%>
                <asp:Label ID="Label2" runat="server" Text="Email"
                     AssociatedControlID="EmailAddress"></asp:Label>
                <asp:TextBox ID="EmailAddress" runat="server" 
                    ToolTip="Enter your email address"
                     TextMode="Email"></asp:TextBox> 

                     <asp:Label ID="Label4" runat="server" Text="Confirm Email"
                     AssociatedControlID="ConfirmEmail"></asp:Label>
                <asp:TextBox ID="ConfirmEmail" runat="server" 
                    ToolTip="Confirm your email address"
                     TextMode="Email"></asp:TextBox> 

                         <asp:Label ID="Label5" runat="server" Text="Password"
                     AssociatedControlID="Password"></asp:Label>
                <asp:TextBox ID="Password" runat="server" 
                    ToolTip="Enter your password"
                     ></asp:TextBox> 

                       <asp:Label ID="Label7" runat="server" Text="Confirm Password"
                     AssociatedControlID="ConfirmPassword"></asp:Label>
                <asp:TextBox ID="ConfirmPassword" runat="server" 
                    ToolTip="Confirm your password"
                     ></asp:TextBox> 
                  
              </fieldset> 
               <p>
               <br />
               <asp:CheckBox ID="Terms" runat="server" Text=" I agree to the the terms of the site." />
           </p>
          
        </div>
        <div class="col-md-6">   
            <div class="col-md-offset-2">
                <p>
                    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Registration"  />&nbsp;&nbsp;
            
                </p>
                <asp:Label ID="Message" runat="server" ></asp:Label><br /><br />
              
            </div>

            <asp:GridView ID="EntriesList" runat="server"
                BorderStyle="None" GridLines="Horizontal" Caption="User Registration">

                <EmptyDataTemplate>
                 No contest entries at this time
                </EmptyDataTemplate>

            </asp:GridView>
        </div>
    </div>
    <script src="../Scripts/bootwrap-freecode.js"></script>


</asp:Content>
