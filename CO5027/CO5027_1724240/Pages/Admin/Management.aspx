<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Management.aspx.cs" Inherits="Pages_Admin_Management" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:LinkButton ID="Product" runat="server" PostBackUrl="~/Pages/Admin/Projectors.aspx"><strong>Go to List of Projectors</strong></asp:LinkButton>

    <p />
    <br />

    <asp:LinkButton ID="TypeBrand" runat="server" PostBackUrl="~/Pages/Admin/TBProjectors.aspx"><strong>Go to List of Projector Types and Brands</strong></asp:LinkButton>

</asp:Content>

