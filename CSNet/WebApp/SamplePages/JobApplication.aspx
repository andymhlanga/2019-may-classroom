<%@ Page Title="Job Application" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JobApplication.aspx.cs" Inherits="WebApp.SamplePages.JobApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h3>Job Application</h3>
<div class="row">
    <div class="col-md-offset-1 col-md-11">
<div class="alert alert-info">

    <blockquote style="font-style:italic">

        This form will illustrate some simple controls to fill out an online job application. This form will use basic 2 column bootstrap formatting with assistance for bootwrap-freecode.
        The form will investigate the processing for a checkbox list. This quote block was formatted using the alert bootstrap coloring. Data will be collected and displayed ina string.

    </blockquote>
</div>



    </div>
</div>

    <div class="row">
        <div class="col-md-6">

            <fieldset class="form-horizontal">

                <legend> This is a fieldset title</legend>
                <%-- Fileds are in pairs of label/ input
                    The label mustr have a associated control ID parameter whose value 
                    is equal to the ID of the input control--%>



                <asp:Label ID="Label1" runat="server" Text="Name" AssociatedControlID="FullName"></asp:Label>

                <asp:TextBox ID="FullName" runat="server" ToolTip="Enter your full name "></asp:TextBox>

                
                <asp:Label ID="Label2" runat="server" Text="Email Address" AssociatedControlID="Email"></asp:Label>

                <asp:TextBox ID="Email" runat="server" placeholder="Enter your email address "></asp:TextBox>

                
                <asp:Label ID="Label3" runat="server" Text="Phone" AssociatedControlID="PhoneNumber"></asp:Label>

                <asp:TextBox ID="PhoneNumber" runat="server" ToolTip="Enter your phone number"></asp:TextBox>


                <asp:Label ID="Label4" runat="server" Text="Time" AssociatedControlID="FullOrPartTime">
                 
                </asp:Label>
                <asp:RadioButtonList ID="FullOrPartTime" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                    <asp:ListItem Value="1">Full Time&nbsp;&nbsp;</asp:ListItem>
                    <asp:ListItem Value="2">Part Time</asp:ListItem>
                </asp:RadioButtonList>


                <asp:Label ID="Label5" runat="server" Text="Position" AssociatedControlID="Jobs"></asp:Label>
                <asp:CheckBoxList ID="Jobs" runat="server">
                    <asp:ListItem>Sales</asp:ListItem>
                    <asp:ListItem>Manufacturing</asp:ListItem>
                    <asp:ListItem>Accounting</asp:ListItem>
                    <asp:ListItem>Shipping/Receiving</asp:ListItem>
                </asp:CheckBoxList>

            </fieldset>


        </div>

         <div class="col-md-6">

             <asp:Button ID="Submit" runat="server" Text="Submit" />&nbsp;&nbsp;
             <asp:Button ID="Clear" runat="server" Text="Clear" />
             <br /><br />

             <asp:Label ID="MessageLabel" runat="server"></asp:Label>

        </div>



    </div>

    <script src="../Scripts/bootwrap-freecode.js"></script>

    </asp:Content>