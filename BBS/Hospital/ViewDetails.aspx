<%@ Page Title="" Language="C#" MasterPageFile="~/Hospital/HospitalMaster.Master" AutoEventWireup="true" CodeBehind="ViewDetails.aspx.cs" Inherits="BBS.Hospital.ViewDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
    var specialKeys = new Array();
    specialKeys.push(8); //Backspace
    function IsNumeric(e) {
        var keyCode = e.which ? e.which : e.keyCode
        var ret = ((keyCode >= 48 && keyCode <= 57) || specialKeys.indexOf(keyCode) != -1);
        document.getElementById("error").style.display = ret ? "none" : "inline";
        return ret;

        if ($(".amnt").val().length == 0) {
            document.getElementById("error").style.display = ret ? "none" : "inline";
        }
    }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
    <tr>
        <td colspan="2" class="header" style="height:40px; color:White;">Blood Details</td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Hospital</td><td><asp:Label ID="hospitalname" Width="200px" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Address</td><td><asp:Label ID="Label2" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Postcode</td><td><asp:Label ID="Label3" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">State</td><td><asp:Label ID="Label4" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Phone Number</td><td><asp:Label ID="phone" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Blood Type</td><td><asp:Label ID="bloodtype" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Blood ID</td><td><asp:Label ID="bloodid" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Expired Date</td><td><asp:Label ID="ed" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Available Amount</td><td><asp:Label ID="amt" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Amount to request</td><td><asp:TextBox onkeypress="return IsNumeric(event);" ID="amnt" runat="server" Width="41px"></asp:TextBox><span ID="error" style="color: Red; display: none">* Input digits only</span><br />
        <asp:RequiredFieldValidator ControlToValidate="amnt" ID="RequiredFieldValidator1" runat="server" ErrorMessage="You must enter amount to request"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td style="border:none;background:#800000;color:white;" colspan="2"><asp:Button ID="Button1" runat="server" Text="Request Blood" 
                onclick="Button1_Click" Width="100px" Height="35px" CausesValidation="true" /><asp:Label
                    ID="Label1" runat="server" Visible="false" Text="Label"></asp:Label></td>
    </tr>
</table>
</asp:Content>
