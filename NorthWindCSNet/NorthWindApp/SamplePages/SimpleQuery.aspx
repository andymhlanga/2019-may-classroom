<%@ Page Title="Simple Query" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SimpleQuery.aspx.cs" Inherits="NorthWindApp.SamplePages.SimpleQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class =" jumbotron">
        <h1> Simple Query</h1>


    </div>
    <div class="row">

        <asp:DropDownList ID="ProductList" runat="server" ></asp:DropDownList > &nbsp;&nbsp;


        <asp:Button ID="Button1" runat="server" Text="Fetch" />
    </div>

    <div class="row">

        <div class="column-md-offset-3"> 

            <fieldset>

                <asp:Label ID="Label1" runat="server" Text="ProductID" AssociatedControlID ="ProductID" ></asp:Label>
                <asp:TextBox ID="ProductID" readonly="true" enabled="false" runat="server"></asp:TextBox>

                  <asp:Label ID="Label2" runat="server" Text="Name" AssociatedControlID ="ProductName" ></asp:Label>
                <asp:TextBox ID="ProductName" readonly="true" enabled="false" runat="server"></asp:TextBox>

                  <asp:Label ID="Label3" runat="server" Text="Qty\Unit" AssociatedControlID ="QuantityPerUnit" ></asp:Label>
                <asp:TextBox ID="QuantityPerUnit" readonly="true" enabled="false" runat="server"></asp:TextBox>

                  <asp:Label ID="Label4" runat="server" Text="Price" AssociatedControlID =" UnitPrice" ></asp:Label>
                <asp:TextBox ID="UnitPrice" readonly="true" enabled="false" runat="server"></asp:TextBox>

                  <asp:Label ID="Label5" runat="server" Text="QOD" AssociatedControlID ="QuantityOnOrder" ></asp:Label>
                <asp:TextBox ID="QuantityOnOrder" readonly="true" enabled="false" runat="server"></asp:TextBox>

                  <asp:Label ID="Label6" runat="server" Text="Label" AssociatedControlID ="ProductID" ></asp:Label>
                <asp:TextBox ID="TextBox5" readonly="true" enabled="false" runat="server"></asp:TextBox>

                  <asp:Label ID="Label7" runat="server" Text="Label" AssociatedControlID ="ProductID" ></asp:Label>
                <asp:TextBox ID="TextBox6" readonly="true" enabled="false" runat="server"></asp:TextBox>



            </fieldset>
        </div>

         

    </div>

    <script src="../Scripts/bootwrap-freecode.js"></script>
</asp:Content>
