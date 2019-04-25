<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="BlockUser.aspx.cs" Inherits="BBS.Admin.Block_User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table><thead>
        <tr class="header" style="height:40px;">
            <td style="color:White;">No</td>
            <td style="color:White;">Name</td>
            <td style="color:White;">IC Number</td>
            <td style="color:White;">Gender</td>
            <td style="color:White;">Medical History</td>
            <td style="color:White;">Status</td>     
        </tr>
        </thead>
        <%=blooddata%>
        
    </table>
    <script src="../Scripts/jquery.simple-table-filter.min.js"></script>
</asp:Content>
