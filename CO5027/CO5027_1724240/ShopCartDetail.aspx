<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShopCartDetail.aspx.cs" Inherits="ShopCartDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="content">
    <div class="block-2 pad-2">
     <h3 class="h3-line"></h3>

        <asp:Panel ID="pnlShoppingCart" runat="server"></asp:Panel> 
       
        <table>
            <tr>
                <td>
                    <b>Total: </b>
                </td>
                <td>
                    <asp:Literal ID="litTotal" runat="server" Text=""></asp:Literal>
                </td>
            </tr>

            <tr>
                <td>
                    <b>Total Amount: </b>
                </td>
                <td>
                    <asp:Literal ID="litTotalAmount" runat="server" Text="" />
                </td>
            </tr>

            <tr>
                <td>
                    <br />
                    <asp:LinkButton ID="ContShop" runat="server" PostBackUrl="~/Default.aspx">Continue Shopping</asp:LinkButton><br />OR<br />                    
                    <asp:Button ID="btnCheckout" runat="server" Text="Check Out" CssClass="btn btn-lg btn-success btn-block" Width="250px" PostBackUrl="~/Success.aspx" />

                </td>
            </tr>

        </table>

    </div>
    </section>

</asp:Content>

