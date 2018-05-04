<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="content">
    
    <div class="block-2 pad-2"> 
        <div class="col-6">
        
        	<h3 class="h3-line">Contact info</h3>
            <div class="map img-border">
            
                <script src="http://maps.googleapis.com/maps/api/js"></script>
            <script>
            function initialize() {
            var mapProp = {
                center: new google.maps.LatLng(4.885421, 114.931361),
                zoom: 20,
                mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);
        }
        google.maps.event.addDomListener(window, 'load', initialize);
        </script>

        <div id="googleMap" style="width:400px;height:300px;"></div>
                  
            </div>
            
            
        </div>
        <div class="col-4 left-2">
        	<h3 class="h3-line">Contact form:</h3>
            <table>
            <!-- Name -->
            <tr>
                <td>
                    Name:</td>
                <td>
                    <asp:TextBox ID="txtName" 
                                    runat="server"
                                    Columns="50" Width="300px" Height="25px"></asp:TextBox>
                </td>
            </tr>

            <!-- Email -->
            <tr>
                <td>
                    Email:</td>
                <td>
                    <asp:TextBox ID="txtEmail" 
                                    runat="server"
                                    Columns="50" Width="300px" Height="25px"></asp:TextBox>
                </td>
            </tr>

            <!-- Subject -->
            <tr>
                <td>
                    Subject:
                </td>
                <td>
                    <asp:DropDownList ID="ddlSubject" runat="server" Height="25px" Width="300px">
                        <asp:ListItem>Ask a question</asp:ListItem>
                        <asp:ListItem>Report a bug</asp:ListItem>
                        <asp:ListItem>Customer support ticket</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>

            <!-- Message -->
            <tr>
                <td>
                    Message:
                </td>
                <td>
                    <asp:TextBox ID="txtMessage" 
                                    runat="server"
                                    Columns="40"
                                    Rows="6" 
                                    TextMode="MultiLine" Height="103px" Width="300px"></asp:TextBox>
                </td>
            </tr>

            <!-- Submit -->
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                        onclick="btnSubmit_Click" />
                </td>
            </tr>
            
            <!-- Results -->
            <tr>
                <td>
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        </div>
       </div>
    </section> 

</asp:Content>

