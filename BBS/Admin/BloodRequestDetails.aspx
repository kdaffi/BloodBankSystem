<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="BloodRequestDetails.aspx.cs" Inherits="BBS.Admin.BloodRequestDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
    var specialKeys = new Array();
    specialKeys.push(8); //Backspace
    function IsNumeric(e) {
        var keyCode = e.which ? e.which : e.keyCode
        var ret = ((keyCode >= 48 && keyCode <= 57) || specialKeys.indexOf(keyCode) != -1);
        document.getElementById("error").style.display = ret ? "none" : "inline";
        return ret;
    }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table>
    <tr>
        <td colspan="2" class="header" style="height:40px; color:White;">Details</td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Hospital</td><td><asp:Label ID="hospitalname" Width="200px" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Blood Type</td><td><asp:Label ID="bloodtype" runat="server" MaxLength="4" Width="100px" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Blood ID</td><td><asp:Label ID="bloodid" runat="server" MaxLength="4" Width="100px" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Expired Date</td><td align="center"><asp:Label ID="ed" runat="server" Width="100px" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Request Amount</td><td><asp:Label ID="amt" runat="server" MaxLength="4" Width="100px" ReadOnly="True"></asp:Label>packs/100ml</td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Available Amount</td><td><asp:Label ID="Label4" runat="server" MaxLength="4" Width="100px" ReadOnly="True"></asp:Label>packs/100ml</td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Phone Number</td><td align="center"><asp:Label ID="phone" runat="server" Width="100px" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Approval</td>
        <td>
            <asp:DropDownList ID="DropDownList1" AutoPostBack="true" OnSelectedIndexChanged="change" runat="server">
                <asp:ListItem Selected="True">Approve</asp:ListItem>
                <asp:ListItem>Reject</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
    <tr>
        <td style="background:#800000;color:white;">Amount Approve</td><td><asp:TextBox ID="amnt" runat="server" onkeypress="return IsNumeric(event);" Width="41px" CssClass="aligncenter"></asp:TextBox><asp:Label
                ID="Label2" runat="server" Visible="false" Text="Label"></asp:Label><asp:Label ID="Label3" runat="server" Text=" packs/100ml"></asp:Label>
                <br /><span ID="error" style="color: Red; display: none">* Input digits only</span></td>  
    </tr>
    
    </tr>
    <%= butt %>
        <asp:Button ID="Button1" runat="server" Width="96px" Height="35px" Text="Submit" OnClick="check"/>
    <%= butt2 %>
    <%--<tr>
        <td colspan="2"></td>
    </tr>--%>
</table>
    <br /><asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="amnt" runat="server" ErrorMessage="* You must enter amount to be approve."></asp:RequiredFieldValidator>
</asp:Content>
