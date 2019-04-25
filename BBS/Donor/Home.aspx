<%@ Page Title="" Language="C#" MasterPageFile="~/Donor/DonorMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BBS.Donor.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table width="400px">
        <tr>
            <th colspan="3">Blood Request From Hospital</th>
        </tr>
        <tr>
            <td style="color:Green;">Approve Request</td>
            <td><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
            <td><a href="AppBloodReqFrom.aspx"><asp:Label ID="Label7" runat="server" Text="Label"><u>View</u></asp:Label></a><asp:Label ID="Label5" runat="server" Text="-"></asp:Label></td>
        </tr>
        <tr>
            <td style="color:Red;">Reject Request</td>
            <td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
            <td><a href="RejBloodReqFrom.aspx"><asp:Label ID="Label8" runat="server" Text="Label"><u>View</u></asp:Label></a><asp:Label ID="Label4" runat="server" Text="-"></asp:Label></td>
        </tr>
        <tr>
            <td style="color:Orange;">Pending Request</td>
            <td><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
            <td><a href="PendBloodReqFrom.aspx"><asp:Label ID="Label9" runat="server" Text="Label"><u>View</u></asp:Label></a><asp:Label ID="Label6" runat="server" Text="-"></asp:Label></td>
        </tr>
    </table>
</asp:Content>
