﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Donor/DonorMaster.Master" AutoEventWireup="true" CodeBehind="RejBloodReqFrom.aspx.cs" Inherits="BBS.Donor.RejBloodReqFrom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table><thead>
        <tr class="header" style="height:40px;">
            <td style="color:White;">Request ID</td>
            <td style="color:White;">Blood ID</td>
            <td style="color:White;">Hospital</td>
            <td style="color:White;">Type</td>
            <td style="color:White;">Location</td>
            <td style="color:White;">Status</td>
            <td style="color:White;">View Details</td>
        </tr>
        </thead>
        <%=blooddata%>
        
    </table>
     <script src="../Scripts/jquery.simple-table-filter.min.js"></script>
</asp:Content>
