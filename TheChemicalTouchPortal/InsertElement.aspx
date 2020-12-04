<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertElement.aspx.cs" Inherits="TheChemicalTouchPortal.InsertElement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Add New Element</h1>
        <table style="width:100%;">
            <tr>
                <td style="width:20%"><strong>Proton Number:</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="protonNumberTextBox" runat="server" Width="100%"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Name:</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="nameTextBox" runat="server" Width="100%"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Chemical Symbol:</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="chemicalSymbolTextBox" runat="server" Width="100%"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Atomic Radius (pm):</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="atomicRadiusTextBox" runat="server" Width="100%"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Relative Atomic Mass (g/mol):</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="relativeAtomicMassTextBox" runat="server" Width="100%"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Density (g/cc):</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="densityTextBox" runat="server" Width="100%"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Is Metal:</strong></td>
                <td style="width:30%">
                    <asp:RadioButtonList ID="isMetalRadioButtonList" runat="server" RepeatDirection="Horizontal" Width="100%">
                        <asp:ListItem Selected="True" Value="True">True</asp:ListItem>
                        <asp:ListItem Value="False">False</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Boiling Point (&deg;C):</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="boilingPointTextBox" runat="server" Width="100%"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Melting Point (&deg;C):</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="meltingPointTextBox" runat="server" Width="100%"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Description:</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="descriptionTextBox" runat="server" Height="150px" TextMode="MultiLine" Width="100%"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Element Image:</strong></td>
                <td style="width:30%">
                    <asp:FileUpload ID="elementImageFileUpload" runat="server" Width="100%" />
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
                    <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Ok" Width="100px" />
&nbsp;<asp:Button ID="clearButton" runat="server" OnClick="clearButton_Click" Text="Clear" Width="100px" />
                </td>
            </tr>
        </table>
</asp:Content>
