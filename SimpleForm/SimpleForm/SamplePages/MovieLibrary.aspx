<%@ Page Title="Movie Library" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MovieLibrary.aspx.cs" Inherits="SimpleForm.SamplePages.MovieLibrary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="page-header">
        <h1>Movie Library</h1>
    </div>

    <div class="row col-md-12">
        <div class="alert alert-info">
            <blockquote style="font-style: italic">
             Fill out the form below to add information on the movie for your movie library 
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
    <%--<asp:RequiredFieldValidator ID="RequiredTitle" runat="server"
        ErrorMessage="Movie Title is required" Display="None" 
         SetFocusOnError="true" ForeColor="Firebrick" 
        ControlToValidate="Title"></asp:RequiredFieldValidator>

    <asp:RequiredFieldValidator ID="RequiredYear" runat="server"
        ErrorMessage="Movie Year  is required" Display="None" 
         SetFocusOnError="true" ForeColor="Firebrick" 
        ControlToValidate="LastName"></asp:RequiredFieldValidator>

<%--        <asp:RequiredFieldValidator ID="RequiredUserName" runat="server"
        ErrorMessage="User Name is required" Display="None" 
         SetFocusOnError="true" ForeColor="Firebrick" 
        ControlToValidate="UserName"></asp:RequiredFieldValidator>--%>



  
    <%-- Compare validator has 3 versions 
        a) datatype parameters type and operator
        b) against a constant parameters type, operator and value
        c) against another form control parameters type, operator and controltocompare --%>
   
<%--    <asp:CompareValidator runat="server" id="ComparePasswords" 
        controltovalidate="Password" controltocompare="ConfirmPassword"
        operator="Equal" type="String" 
        errormessage="The passwords you typed do not match!" /><br />--%>

<%-- Validation error Display --%>
   <%-- <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Correct the input for the following errors:"
         CssClass="alert alert-warning"/>

    <div class="row">
        <div class ="col-md-6">
            <fieldset class="form-horizontal">
                <legend>Movie Library</legend>

                <asp:Label ID="Label1" runat="server" Text="First Name"
                     AssociatedControlID="Title"></asp:Label>
                <asp:TextBox ID="Title" runat="server" 
                    ToolTip="Enter movie title." MaxLength="25"></asp:TextBox> 
                  
                 <asp:Label ID="Label6" runat="server" Text="Last Name"
                     AssociatedControlID="Year"></asp:Label>
                <asp:TextBox ID="Year" runat="server" 
                    ToolTip="Enter movie release year." MaxLength="4"></asp:TextBox> --%>
                        
                
     
                 <%-- TextMode is Html5 restriction which executes
                     prior to any Validation Control--%>
            <%--    <asp:Label ID="Label2" runat="server" Text="Media Option"
                     AssociatedControlID="Media"></asp:Label>

                     <asp:RadioButtonList ID="Media" runat="server"
                     RepeatDirection="Vertical" RepeatLayout="Flow">

                    <asp:ListItem Value="1">DVD&nbsp;&nbsp;</asp:ListItem>
                    <asp:ListItem Value="2">VHS</asp:ListItem>
                   <asp:ListItem Value="3">File</asp:ListItem>
                </asp:RadioButtonList>




                 <asp:Label ID="Label3" runat="server" Text="Rating Option"
                     AssociatedControlID="Rating"></asp:Label>

                     <asp:RadioButtonList ID="Rating" runat="server"
                     RepeatDirection="Vertical" RepeatLayout="Flow">
                    <asp:ListItem Value="1">General (G)&nbsp;&nbsp;</asp:ListItem>
                    <asp:ListItem Value="2">Parental Guidence (PG)</asp:ListItem>
                   <asp:ListItem Value="3">14A</asp:ListItem>
                   <asp:ListItem Value="4">18A</asp:ListItem>
                   <asp:ListItem Value="5">Restricted (R)</asp:ListItem>
                </asp:RadioButtonList>


              </fieldset> 
          
        
        </div>
        <div class="col-md-6">   
            <div class="col-md-offset-2">
                <p>
                    <asp:Button ID="Submit" runat="server" Text="Add to library" OnClick="Submit_Click" />&nbsp;&nbsp;
            
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
    <script src="../Scripts/bootwrap-freecode.js"></script>--%>--%>



</asp:Content>
