<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ViewDetails.aspx.cs" Inherits="BBS.Admin.ViewDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
    <tr>
        <td colspan="2" class="header" style="height:40px; color:White;">Blood Details</td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Hospital</td><td><asp:Label ID="hospitalname" Width="200px" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Address</td><td><asp:Label ID="Label2" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Postcode</td><td><asp:Label ID="Label3" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">State</td><td><asp:Label ID="Label4" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Phone Number</td><td><asp:Label ID="phone" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Blood Type</td><td><asp:Label ID="bloodtype" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Blood ID</td><td><asp:Label ID="bloodid" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Expired Date</td><td><asp:Label ID="ed" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Available Amount</td><td><asp:Label ID="amt" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
</table>
</asp:Content>