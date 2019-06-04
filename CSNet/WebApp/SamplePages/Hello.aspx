<%@ Page Title="Hello" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Hello.aspx.cs" Inherits="WebApp.SamplePages.Hello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%-- This MainContent is the default body content --%>

    <asp:Label ID="MessageArea" runat="server" Text="Label"></asp:Label>

    <br />


    <%-- the control is an instance of the class the ID is the coding name of this instance --%>

    <asp:Button ID="Submit" runat="server" Text="Press Me" OnClick="Submit_Click" />

    &nbsp; &nbsp;
    <asp:Button ID="Reset" runat="server" Text="Clear" OnClick="Reset_Click" />


</asp:Content>
