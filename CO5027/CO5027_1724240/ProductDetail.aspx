<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProductDetail.aspx.cs" Inherits="ProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <section id="content">
    <div class="block-2 pad-2">
      <h3 class="h3-line"></h3>
       <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imgProduct" runat="server" CssClass="detailsImage" />
            </td>
            <td>
                <h2>
                    <asp:Label ID="lblTitle" runat="server"></asp:Label></h2>
                <hr />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDescription" runat="server" CssClass="detailsDescription"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblPrice" runat="server" CssClass="detailsPrice"></asp:Label><br />
                Quantity:<asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList><br />
                
                <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-lg btn-success btn-block" OnClick="btnAdd_Click" Text="Add Product" />
                <br />
                
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Product No:
                <br />
                <asp:Label ID="lblItemNr" runat="server" Style="font-style: italic"></asp:Label>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblAvailable" runat="server" CssClass="productPrice">Available!</asp:Label>
            </td>
        </tr>

        <tr>
                <td>
                    <br />
                    <asp:LinkButton ID="Back" runat="server" PostBackUrl="~/Default.aspx">Back to Products page</asp:LinkButton>                   
                </td>
            </tr>

    </table>
        	  


    </div>
    </section> 

</asp:Content>

