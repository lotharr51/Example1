<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsExample._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <h2>
        My favorite color is <asp:Label ID="colorLabel" runat="server" Text="Not Selected"></asp:Label>
    </h2>

    Not your favorite color? Select a different one:
            
    <asp:DropDownList ID="colorListDropDown" runat="server" AutoPostBack="True" DataSourceID="colorSourceXML" DataTextField="Name" DataValueField="Name" OnDataBound="ColorListDropDown_DataBound" OnSelectedIndexChanged="colorListDropDown_SelectedIndexChanged">
    </asp:DropDownList>

            
                
    <br />
    <br />
    Colors not selected:
    <asp:Label ID="colorsNotSelected" runat="server" Text="Label"></asp:Label>
        &nbsp;<asp:XmlDataSource ID="colorSourceXML" runat="server" DataFile="~/Content/Colors.xml"></asp:XmlDataSource>
</asp:Content>
