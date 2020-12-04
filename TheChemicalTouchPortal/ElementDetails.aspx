<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ElementDetails.aspx.cs" Inherits="TheChemicalTouchPortal.ElementDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h1>Element Details</h1>
    <table style="width:100%;">
            <tr>
                <td style="width:20%">
                    <asp:Image ID="elementImage" runat="server" Height="150px" Width="120px" />
                </td>
                <td style="width:30%">
                    &nbsp;</td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Proton Number:</strong></td>
                <td style="width:30%">
                    <asp:Label ID="protonNumberLabel" runat="server" Width="100%"></asp:Label>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Name:</strong></td>
                <td style="width:30%">
                    <asp:Label ID="nameLabel" runat="server" Width="100%"></asp:Label>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Chemical Symbol:</strong></td>
                <td style="width:30%">
                    <asp:Label ID="chemicalSymbolLabel" runat="server" Width="100%"></asp:Label>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Atomic Radius:</strong></td>
                <td style="width:30%">
                    <asp:Label ID="atomicRadiusLabel" runat="server" Width="100%"></asp:Label>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Relative Atomic Mass:</strong></td>
                <td style="width:30%">
                    <asp:Label ID="relativeAtomicMassLabel" runat="server" Width="100%"></asp:Label>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Density:</strong></td>
                <td style="width:30%">
                    <asp:Label ID="densityLabel" runat="server" Width="100%"></asp:Label>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Is Metal:</strong></td>
                <td style="width:30%">
                    <asp:RadioButtonList ID="isMetalRadioButtonList" runat="server" RepeatDirection="Horizontal" Width="100%" Enabled="False">
                        <asp:ListItem Selected="True" Value="True">True</asp:ListItem>
                        <asp:ListItem Value="False">False</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Boiling Point:</strong></td>
                <td style="width:30%">
                    <asp:Label ID="boilingPointLabel" runat="server" Width="100%"></asp:Label>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Melting Point:</strong></td>
                <td style="width:30%">
                    <asp:Label ID="meltingPointLabel" runat="server" Width="100%"></asp:Label>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>State at Room Temperature (30&deg;C):</strong></td>
                <td style="width:30%">
                    <asp:Label ID="stateLabel" runat="server" Width="100%"></asp:Label>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Description:</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="descriptionTextBox" runat="server" Height="150px" TextMode="MultiLine" Width="100%" ReadOnly="True"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:30%">&nbsp;</td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="statusLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="backButton" runat="server" OnClick="backButton_Click" Text="Back" Width="100px" />
                </td>
            </tr>
        </table>
</asp:Content>
