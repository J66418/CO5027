<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TBProjectors.aspx.cs" Inherits="Pages_Admin_TBProjectors" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="content">
    <div class="block-2 pad-2">
        
        <asp:LinkButton ID="AddProductType" runat="server" PostBackUrl="~/Pages/Admin/ManageProjectorType.aspx"><strong>Add New Projector Type</strong></asp:LinkButton>
        <p style="clear: both">

            <asp:GridView ID="grdProjectorType" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ProjectorTypeID" DataSourceID="sdsProjectorType" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="ProjectorTypeID" HeaderText="ProjectorTypeID" InsertVisible="False" ReadOnly="True" SortExpression="ProjectorTypeID" />
                    <asp:BoundField DataField="ProjectorTypeName" HeaderText="ProjectorTypeName" SortExpression="ProjectorTypeName" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="sdsProjectorType" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ProjectorCS %>" DeleteCommand="DELETE FROM [ProductType] WHERE [ProjectorTypeID] = @original_ProjectorTypeID AND [ProjectorTypeName] = @original_ProjectorTypeName" InsertCommand="INSERT INTO [ProductType] ([ProjectorTypeName]) VALUES (@ProjectorTypeName)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [ProductType]" UpdateCommand="UPDATE [ProductType] SET [ProjectorTypeName] = @ProjectorTypeName WHERE [ProjectorTypeID] = @original_ProjectorTypeID AND [ProjectorTypeName] = @original_ProjectorTypeName">
                <DeleteParameters>
                    <asp:Parameter Name="original_ProjectorTypeID" Type="Int32" />
                    <asp:Parameter Name="original_ProjectorTypeName" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ProjectorTypeName" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ProjectorTypeName" Type="String" />
                    <asp:Parameter Name="original_ProjectorTypeID" Type="Int32" />
                    <asp:Parameter Name="original_ProjectorTypeName" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>

        </p>

        
        
        
        <asp:LinkButton ID="AddProductBrand" runat="server" PostBackUrl="~/Pages/Admin/ManageProjectorBrand.aspx"><strong>Add New Projector Brand</strong></asp:LinkButton>
        <p style="clear: both">
            
            <asp:GridView ID="grdProjectorBrand" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ProjectorBrandID" DataSourceID="sdsProjectorBrand" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="ProjectorBrandID" HeaderText="ProjectorBrandID" InsertVisible="False" ReadOnly="True" SortExpression="ProjectorBrandID" />
                    <asp:BoundField DataField="ProjectorBrandName" HeaderText="ProjectorBrandName" SortExpression="ProjectorBrandName" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="sdsProjectorBrand" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ProjectorCS %>" DeleteCommand="DELETE FROM [ProductBrand] WHERE [ProjectorBrandID] = @original_ProjectorBrandID AND [ProjectorBrandName] = @original_ProjectorBrandName" InsertCommand="INSERT INTO [ProductBrand] ([ProjectorBrandName]) VALUES (@ProjectorBrandName)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [ProductBrand]" UpdateCommand="UPDATE [ProductBrand] SET [ProjectorBrandName] = @ProjectorBrandName WHERE [ProjectorBrandID] = @original_ProjectorBrandID AND [ProjectorBrandName] = @original_ProjectorBrandName">
                <DeleteParameters>
                    <asp:Parameter Name="original_ProjectorBrandID" Type="Int32" />
                    <asp:Parameter Name="original_ProjectorBrandName" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ProjectorBrandName" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ProjectorBrandName" Type="String" />
                    <asp:Parameter Name="original_ProjectorBrandID" Type="Int32" />
                    <asp:Parameter Name="original_ProjectorBrandName" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
            
        </p>

     </div>
    </section> 

</asp:Content>

