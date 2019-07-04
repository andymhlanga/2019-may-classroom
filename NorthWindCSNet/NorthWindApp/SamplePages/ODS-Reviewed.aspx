<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ODS-Reviewed.aspx.cs" Inherits="NorthwindApp.SamplePages.ODS_Reviewed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>ODS Review</h1>

    <asp:Label ID="Label1" runat="server" Text="Enter a product name"></asp:Label> &nbsp;&nbsp;

    <asp:TextBox ID="ProductNameArg" runat="server"></asp:TextBox>  &nbsp;&nbsp;

    <asp:Button ID="ProductFetch" runat="server" Text="Button" OnClick="ProductFetch_Click" /> <br /> <br />

    <asp:Label ID="MessageLabel" runat="server"></asp:Label><br /> <br />

    <asp:GridView ID="ProductList" runat="server" AutoGenerateColumns="False" DataSourceID="ProductListODS" AllowPaging="True">
        <Columns>
            <asp:CommandField SelectText="View" ShowSelectButton="True"></asp:CommandField>
            <asp:TemplateField HeaderText="Product" SortExpression="ProductID" Visible="False">
               
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Bind("ProductID") %>' ID="ProductID"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName"></asp:BoundField>
            <asp:TemplateField HeaderText="Supplier" SortExpression="SupplierID">
                
                <ItemTemplate>
                <%--    <asp:Label runat="server" Text='<%# Bind("SupplierID") %>' ID="Label2"></asp:Label>--%>

                    <asp:DropDownList ID="SupplierList" runat="server" 
                        DataSourceID="SupplierListODS" 
                        DataTextField="CompanyName" 
                        DataValueField="SupplierID"
                          SelectedValue='<%# Bind("SupplierID") %>'                        
                        >                      
                    </asp:DropDownList>


                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="QoH" SortExpression="UnitsInStock">
                
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Bind("UnitsInStock") %>' ID="Label3"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Disc" SortExpression="Discontinued">
                
                <ItemTemplate>
                    <asp:CheckBox runat="server" Checked='<%# Bind("Discontinued") %>' Enabled="false" ID="CheckBox1"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:BoundField DataField="UnitsOnOrder" HeaderText="UnitsOnOrder" SortExpression="UnitsOnOrder"></asp:BoundField>
            <asp:BoundField DataField="ReorderLevel" HeaderText="ReorderLevel" SortExpression="ReorderLevel"></asp:BoundField>
            <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" SortExpression="Discontinued"></asp:CheckBoxField>
            <asp:BoundField DataField="ProductDescription" HeaderText="ProductDescription" ReadOnly="True" SortExpression="ProductDescription"></asp:BoundField>
        </Columns>

        <EmptyDataTemplate>

            no data to view
        </EmptyDataTemplate>

    </asp:GridView>


    <asp:ObjectDataSource ID="ProductListODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Product_FindByName" TypeName="NorthwindSystem.BLL.ProductController">
        <SelectParameters>
            <asp:ControlParameter ControlID="ProductNameArg" PropertyName="Text" DefaultValue="zzzzz" Name="productname" Type="String"></asp:ControlParameter>
        </SelectParameters>
    </asp:ObjectDataSource>



    <asp:ObjectDataSource ID="SupplierListODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Supplier_List" TypeName="NorthwindSystem.BLL.SupplierController"></asp:ObjectDataSource>


</asp:Content>
