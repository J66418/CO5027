<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Success.aspx.cs" Inherits="Success" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="content">
    <div class="block-2 pad-2">
      
       <br />
        <h2 class="h2-line">Your order has been processed. Please wait to receive a notification on your order.</h2>
        <asp:Image ID="Congrates" runat="server" ImageUrl="~/Images/Thank You.jpg" CssClass="img-border pad-3" Width="100%" />
        	  


    </div>
    </section> 

</asp:Content>

