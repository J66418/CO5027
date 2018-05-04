<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="content">
    <div class="block-2 pad-2">
      <h3 class="h3-line"></h3>
       
        <asp:Panel ID="pnlProducts" runat="server"></asp:Panel> 	  

        <p style="clear:both"></p>

    </div>
    </section> 

</asp:Content>

