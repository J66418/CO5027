<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageProjectorBrand.aspx.cs" Inherits="Pages_Admin_ManageProjectorBrand" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <p>
       Projector Brand Name:</p>
    <p>
        <asp:TextBox ID="txtProjectorBrand" runat="server" CssClass="inputs"></asp:TextBox>
    </p>

    <p>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" CssClass="button" />
    </p>
    <p>
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </p>

</asp:Content>

