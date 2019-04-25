<%@ Page Title="" Language="C#" MasterPageFile="Style.Master" AutoEventWireup="true" CodeBehind="BloodRequest.aspx.cs" Inherits="BBS.BloodRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table">
        <tr>
            <th colspan="7">REQUEST TO OTHER HOSPITAL / BLOOD DONOR</th>
        </tr>
        <tr>
            <th style="width:10%";>Request ID</th>
            <th style="width:10%";>Blood ID</th>
            <th style="width:30%";>Hospital</th>
            <th style="width:10%";>Type</th>
            <th style="width:20%";>Location</th>
            <th style="width:10%";>Request</th>
            <th style="width:10%";>Details</th>
        </tr>
        <tr>
            <td>R001</td>
            <td>B001</td>
            <td>Hospital Kajang</td>
            <td>A+</td>
            <td>Selangor</td>
            <td>12</td>
            <td style="cursor:pointer";><u>View Details</u></td>
        </tr>
        <tr>
            <td>R002</td>
            <td>B002</td>
            <td>Hospital Putrajaya</td>
            <td>B</td>
            <td>WP. Putrajaya</td>
            <td>4</td>
            <td style="cursor:pointer";><u>View Details</u></td>
        </tr>
        <tr>
            <td>R003</td>
            <td>B003</td>
            <td>Hospital Sultan Ismail</td>
            <td>O</td>
            <td>Johor</td>
            <td>10</td>
            <td style="cursor:pointer";><u>View Details</u></td>
        </tr>
        </table>
</asp:Content>
