<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageProjector.aspx.cs" Inherits="Pages_Admin_ManageProjector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <p>
        Projector Model:
    </p>
    <p>
        <asp:TextBox ID="txtProjectorModel" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
    <p>
        Projector Type:</p>
    <p>
        <asp:DropDownList ID="ddlProjectorType" runat="server" CssClass="inputs" DataSourceID="ProjectorType" DataTextField="ProjectorTypeName" DataValueField="ProjectorTypeID">
        </asp:DropDownList>

        <asp:SqlDataSource ID="ProjectorType" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectorCS %>" SelectCommand="SELECT * FROM [ProductType] ORDER BY [ProjectorTypeName]"></asp:SqlDataSource>

    </p>

     <p>
        Projector Brand:</p>
    <p>
        <asp:DropDownList ID="ddlProjectorBrand" runat="server" CssClass="inputs" DataSourceID="ProjectorBrand" DataTextField="ProjectorBrandName" DataValueField="ProjectorBrandID">
        </asp:DropDownList>

        <asp:SqlDataSource ID="ProjectorBrand" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectorCS %>" SelectCommand="SELECT * FROM [ProductBrand] ORDER BY [ProjectorBrandName]"></asp:SqlDataSource>

    </p>
    <p>
        Price:</p>
    <p>
        <asp:TextBox ID="txtPrice" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
    <p>
        Image:</p>
    <p>
        <asp:DropDownList ID="ddlImage" runat="server" CssClass="inputs" Width="270">
        </asp:DropDownList>
    </p>
    <p>
        Description:</p>
    <p>
        <asp:TextBox ID="txtDescription" runat="server" Height="74px" TextMode="MultiLine" CssClass="inputs" Width="240px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="button" />
    </p>
    <p>
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </p>

</asp:Content>

