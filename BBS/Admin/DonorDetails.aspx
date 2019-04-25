<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="DonorDetails.aspx.cs" Inherits="BBS.Admin.DonorDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table>
    <tr>
        <td colspan="2" class="header" style="height:40px; color:White;">Donor Details</td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Donor Name</td><td style="width:170px;"><asp:Label Width="170px" ID="hospitalname" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Gender</td><td><asp:Label ID="gender" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Age</td><td><asp:Label ID="Label1" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Address</td><td><asp:Label ID="Label2" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Postcode</td><td><asp:Label ID="Label3" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Location</td><td><asp:Label ID="Label4" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Phone Number</td><td><asp:Label ID="Label5" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Blood Type</td><td><asp:Label ID="bloodtype" runat="server" MaxLength="4" Width="40px" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Blood ID</td><td><asp:Label ID="bloodid" runat="server" MaxLength="4" Width="40px" ReadOnly="True"></asp:Label></td>
    </tr>
   
    <tr>
        <td style="background:#800000;" colspan="2"><asp:Button ID="Button1" Width="100px" Height="35px" runat="server" Text="Request Blood" 
                onclick="Button1_Click" />
            
                </td>
    </tr>
</table>
</asp:Content>
