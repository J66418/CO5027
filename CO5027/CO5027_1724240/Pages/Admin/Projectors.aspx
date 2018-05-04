<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Projectors.aspx.cs" Inherits="Pages_Admin_Projectors" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="content">
    <div class="block-2 pad-2">
        
        <asp:LinkButton ID="AddProduct" runat="server" PostBackUrl="~/Pages/Admin/ManageProjector.aspx"><strong>Add New Projector Model</strong></asp:LinkButton>
        <p style="clear: both">

            
            <asp:GridView ID="grdProjectorModel" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ProjectorID" DataSourceID="sdsProjectorModel" ForeColor="#333333" GridLines="None" OnRowEditing="grdProjectorModel_RowEditing">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="ProjectorID" HeaderText="ProjectorID" InsertVisible="False" ReadOnly="True" SortExpression="ProjectorID" />
                    <asp:BoundField DataField="ProjectorName" HeaderText="ProjectorName" SortExpression="ProjectorName" />
                    <asp:BoundField DataField="ProjectorTypeID" HeaderText="ProjectorTypeID" SortExpression="ProjectorTypeID" />
                    <asp:BoundField DataField="ProjectorBrandID" HeaderText="ProjectorBrandID" SortExpression="ProjectorBrandID" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" />
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
            <asp:SqlDataSource ID="sdsProjectorModel" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ProjectorCS %>" DeleteCommand="DELETE FROM [Product] WHERE [ProjectorID] = @original_ProjectorID AND [ProjectorName] = @original_ProjectorName AND [ProjectorTypeID] = @original_ProjectorTypeID AND (([ProjectorBrandID] = @original_ProjectorBrandID) OR ([ProjectorBrandID] IS NULL AND @original_ProjectorBrandID IS NULL)) AND [Price] = @original_Price AND (([Description] = @original_Description) OR ([Description] IS NULL AND @original_Description IS NULL)) AND [Image] = @original_Image" InsertCommand="INSERT INTO [Product] ([ProjectorName], [ProjectorTypeID], [ProjectorBrandID], [Price], [Description], [Image]) VALUES (@ProjectorName, @ProjectorTypeID, @ProjectorBrandID, @Price, @Description, @Image)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Product]" UpdateCommand="UPDATE [Product] SET [ProjectorName] = @ProjectorName, [ProjectorTypeID] = @ProjectorTypeID, [ProjectorBrandID] = @ProjectorBrandID, [Price] = @Price, [Description] = @Description, [Image] = @Image WHERE [ProjectorID] = @original_ProjectorID AND [ProjectorName] = @original_ProjectorName AND [ProjectorTypeID] = @original_ProjectorTypeID AND (([ProjectorBrandID] = @original_ProjectorBrandID) OR ([ProjectorBrandID] IS NULL AND @original_ProjectorBrandID IS NULL)) AND [Price] = @original_Price AND (([Description] = @original_Description) OR ([Description] IS NULL AND @original_Description IS NULL)) AND [Image] = @original_Image">
                <DeleteParameters>
                    <asp:Parameter Name="original_ProjectorID" Type="Int32" />
                    <asp:Parameter Name="original_ProjectorName" Type="String" />
                    <asp:Parameter Name="original_ProjectorTypeID" Type="Int32" />
                    <asp:Parameter Name="original_ProjectorBrandID" Type="Int32" />
                    <asp:Parameter Name="original_Price" Type="Decimal" />
                    <asp:Parameter Name="original_Description" Type="String" />
                    <asp:Parameter Name="original_Image" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ProjectorName" Type="String" />
                    <asp:Parameter Name="ProjectorTypeID" Type="Int32" />
                    <asp:Parameter Name="ProjectorBrandID" Type="Int32" />
                    <asp:Parameter Name="Price" Type="Decimal" />
                    <asp:Parameter Name="Description" Type="String" />
                    <asp:Parameter Name="Image" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ProjectorName" Type="String" />
                    <asp:Parameter Name="ProjectorTypeID" Type="Int32" />
                    <asp:Parameter Name="ProjectorBrandID" Type="Int32" />
                    <asp:Parameter Name="Price" Type="Decimal" />
                    <asp:Parameter Name="Description" Type="String" />
                    <asp:Parameter Name="Image" Type="String" />
                    <asp:Parameter Name="original_ProjectorID" Type="Int32" />
                    <asp:Parameter Name="original_ProjectorName" Type="String" />
                    <asp:Parameter Name="original_ProjectorTypeID" Type="Int32" />
                    <asp:Parameter Name="original_ProjectorBrandID" Type="Int32" />
                    <asp:Parameter Name="original_Price" Type="Decimal" />
                    <asp:Parameter Name="original_Description" Type="String" />
                    <asp:Parameter Name="original_Image" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>

            
        </p>

     </div>
    </section> 

</asp:Content>

