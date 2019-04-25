<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="BloodRequestDonorDetails.aspx.cs" Inherits="BBS.Admin.BloodRequestDonorDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table>
    <tr>
        <td colspan="2" class="header" style="height:40px; color:White;">Details</td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Blood ID</td><td><asp:Label ID="bloodid" runat="server" MaxLength="4" Width="40px" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Blood Type</td><td><asp:Label ID="bloodtype" runat="server" MaxLength="4" Width="40px" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Donor Name</td><td><asp:Label ID="donorname" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
     <tr>
        <td style="background:#800000;color:white;">Gender</td><td><asp:Label ID="Label1" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Age</td><td><asp:Label ID="Label2" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Address</td><td><asp:Label ID="Label3" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Postcode</td><td><asp:Label ID="Label4" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Location</td><td><asp:Label ID="location" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Phone Number</td><td><asp:Label ID="phone" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td colspan="2" class="header" style="height:40px; color:White;">Approval</td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Status</td><td style="font-weight:bold;"><asp:Label ID="status" runat="server" Text="Label"></asp:Label></td>  
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Donation Date</td><td style="font-weight:bold;"><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>  
    </tr>

</table>
</asp:Content>
