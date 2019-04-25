<%@ Page Title="" Language="C#" MasterPageFile="~/Hospital/HospitalMaster.Master" AutoEventWireup="true" CodeBehind="BloodBank.aspx.cs" Inherits="BBS.Hospital.BloodBank" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:RadioButton ID="RadioButton1" AutoPostBack="true" GroupName="type" value="hospital" Checked="true" runat="server" />Hospital
    <asp:RadioButton ID="RadioButton2" AutoPostBack="true" GroupName="type" value="donor" runat="server" />Blood Donor
    <table>

        <%=blooddata%>
     </table>
     <script src="../Scripts/jquery.simple-table-filter.min.js"></script>   
</asp:Content>
