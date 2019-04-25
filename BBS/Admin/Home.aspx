<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BBS.Admin.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="400px">
        <tr>
            <th colspan="3">Blood Request From Other Hospital</th>
        </tr>
        <tr>
            <td style="color:Green;">Approve Request</td>
            <td><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
            <td><a href="AppBloodRequestFrom.aspx"><asp:Label ID="Label4" runat="server" Text="Label"><u>View</u></asp:Label></a><asp:Label ID="Label5" runat="server" Text="-"></asp:Label></td>
        </tr>
        <tr>
            <td style="color:Red;">Reject Request</td>
            <td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
            <td><a href="RejBloodReqFrom.aspx"><asp:Label ID="Label6" runat="server" Text="Label"><u>View</u></asp:Label></a><asp:Label ID="Label10" runat="server" Text="-"></asp:Label></td>
        </tr>
        <tr>
            <td style="color:Orange;">Pending Request</td>
            <td><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
            <td><a href="PendBloodReqFrom.aspx"><asp:Label ID="Label11" runat="server" Text="Label"><u>View</u></asp:Label></a><asp:Label ID="Label12" runat="server" Text="-"></asp:Label></td>
        </tr>
    </table>
    <br />
    
    <table width="400px">
        <tr>
            <th colspan="3">Blood Request To Blood Donor</th>
        </tr>
        <tr>
            <td style="color:Green;">Approve Request</td>
            <td><asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></td>
            <td><a href="AppBloodReqTo.aspx"><asp:Label ID="Label13" runat="server" Text="Label"><u>View</u></asp:Label></a><asp:Label ID="Label14" runat="server" Text="-"></asp:Label></td>
        </tr>
        <tr>
            <td style="color:Red;">Reject Request</td>
            <td><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></td>
            <td><a href="RejBloodReqTo.aspx"><asp:Label ID="Label15" runat="server" Text="Label"><u>View</u></asp:Label></a><asp:Label ID="Label16" runat="server" Text="-"></asp:Label></td>
        </tr>
        <tr>
            <td style="color:Orange;">Pending Request</td>
            <td><asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></td>
            <td><a href="PendBloodReqTo.aspx"><asp:Label ID="Label17" runat="server" Text="Label"><u>View</u></asp:Label></a><asp:Label ID="Label18" runat="server" Text="-"></asp:Label></td>
        </tr>
    </table>
</asp:Content>
