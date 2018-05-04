<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Pages_Account_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="content">
  
        <div class="col-5 left-2">
        	<h3 class="h3-line">User Register:</h3>
          
              <p>
        <asp:Literal runat="server" ID="litStatusMessage" />
            </p>

            User name:<br />
            <asp:TextBox runat="server" ID="txtUserName" CssClass="inputs" /><br />

            Password:
            <br />
            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="inputs" /><br />

            Confirm password:
            <br />
            <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password" CssClass="inputs" /><br />

            Customer Name:<br />
            <asp:TextBox runat="server" ID="txtCustomerName" CssClass="inputs" /><br />

            E-Mail:<br />
            <asp:TextBox runat="server" ID="txtEmail" CssClass="inputs" /><br />

            Phone Number:<br />
            <asp:TextBox runat="server" ID="txtPhoneNumber" CssClass="inputs" /><br />

        
            
            <p>
        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" CssClass="button" Width="150px" />
            </p> 
            
        </div>
   
    </section> 

</asp:Content>

