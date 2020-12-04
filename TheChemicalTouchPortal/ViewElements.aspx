<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewElements.aspx.cs" Inherits="TheChemicalTouchPortal.ViewElements" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvElements" runat="server" AutoGenerateColumns="False" Height="183px" OnRowCommand="gvElements_RowCommand" style="margin-right: 0px" Width="335px">
        <Columns>
            <asp:BoundField DataField="ProtonNumber" HeaderText="Proton Number" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="Symbol" HeaderText="Chemical Symbol" />
            <asp:BoundField DataField="Radius" HeaderText="Atomic Radius (pm)" />
            <asp:BoundField DataField="Mass" HeaderText="Relative Atomic Mass (g/mol)" />
            <asp:BoundField DataField="Density" HeaderText="Density (g/cc)" />
            <asp:BoundField DataField="BoilingPoint" HeaderText="B.P (*C)" />
            <asp:BoundField DataField="MeltingPoint" HeaderText="M.P (*C)" />
            <asp:ButtonField CommandName="Delete" Text="Delete" />
            <asp:ButtonField CommandName="Select" Text="Select" />
        </Columns>
    </asp:GridView>
</asp:Content>
