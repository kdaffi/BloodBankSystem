<%@ Page Title="" Language="C#" MasterPageFile="~/Hospital/HospitalMaster.Master" AutoEventWireup="true" CodeBehind="RejBloodReqToDonor.aspx.cs" Inherits="BBS.Hospital.RejBloodReqToDonor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table>
<thead>
        <tr class="header" style="height:40px;">
            <td style="color:White;">Request ID</td>
            <td style="color:White;">Blood ID</td>
            <td style="color:White;">Name</td>
            <td style="color:White;">Type</td>
            <td style="color:White;">Location</td>
            <td style="color:White;">Status</td>
            <td style="color:White;">View Details</td>
            <td style="color:White;">Delete</td>
        </tr>
 </thead>       
        <%=blooddata%>
        
    </table>
    <script src="../Scripts/jquery.simple-table-filter.min.js"></script>  
</asp:Content>
