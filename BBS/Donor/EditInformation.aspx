<%@ Page Title="" Language="C#" MasterPageFile="~/Donor/DonorMaster.Master" AutoEventWireup="true" CodeBehind="EditInformation.aspx.cs" Inherits="BBS.Donor.EditInformation" %>
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
    function IsNumeric1(e) {
        var keyCode = e.which ? e.which : e.keyCode
        var ret = ((keyCode >= 48 && keyCode <= 57) || specialKeys.indexOf(keyCode) != -1);
        document.getElementById("error1").style.display = ret ? "none" : "inline";
        return ret;
    }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border="1px" style="border-color:#800000;border-radius:5px;">
    <tr>
        <td colspan="2" style="background:#800000;color:white;">Edit Information</td>
        </tr>
    <tr>
        <td style="background:#800000;color:white;"><asp:Label ID="Name" runat="server" Text="Name"></asp:Label></td>
        <td style="border:none;float:left;"><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;"><asp:Label ID="Label8" runat="server" Text="IC Number"></asp:Label></td>
        <td style="border:none;float:left;"><asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;"><asp:Label ID="Label6" runat="server" Text="Gender"></asp:Label></td>
        <td style="border:none;float:left;"><asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;"><asp:Label ID="Label3" runat="server" Text="Age"></asp:Label></td>
        <td style="border:none;float:left;"><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;"><asp:Label ID="Label10" runat="server" Text="Blood Type"></asp:Label></td>
        <td style="border:none;float:left;"><asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
         <td style="background:#800000;color:white;"><asp:Label ID="Label1" runat="server" Text="Address"></asp:Label></td>
         <td style="border:none;float:left;width:300px;"><asp:TextBox width="280px" ID="TextBox4" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
         <td style="background:#800000;color:white;"><asp:Label ID="Label2" runat="server" Text="Postcode"></asp:Label></td>
         <td style="border:none;float:left;"><asp:TextBox onkeypress="return IsNumeric(event);" ID="TextBox5" runat="server"></asp:TextBox>
         <br /><span ID="error" style="color: Red; display: none">* Input digits only</span></td>
    </tr>
    <tr>
         <td style="background:#800000;color:white;"><asp:Label ID="Location" runat="server" Text="State"></asp:Label></td>
         <td style="float:left;border:none;float:left;">
                            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true">
                                <asp:ListItem Selected="True" Value="state">Select State</asp:ListItem>
                                <asp:ListItem>W.P Kuala Lumpur</asp:ListItem>
                                <asp:ListItem>W.P Labuan</asp:ListItem>
                                <asp:ListItem>W.P Putrajaya</asp:ListItem>
                                <asp:ListItem>Johor</asp:ListItem>
                                <asp:ListItem>Kedah</asp:ListItem>
                                <asp:ListItem>Kelantan</asp:ListItem>
                                <asp:ListItem>Malacca</asp:ListItem>
                                <asp:ListItem>Negeri Sembilan</asp:ListItem>
                                <asp:ListItem>Pahang</asp:ListItem>
                                <asp:ListItem>Perak</asp:ListItem>
                                <asp:ListItem>Perlis</asp:ListItem>
                                <asp:ListItem>Penang</asp:ListItem>
                                <asp:ListItem>Sabah</asp:ListItem>
                                <asp:ListItem>Sarawak</asp:ListItem>
                                <asp:ListItem>Selangor</asp:ListItem>
                                <asp:ListItem>Terengganu</asp:ListItem>
                            </asp:DropDownList>
                        </td>
    </tr>
    <tr>
         <td style="background:#800000;color:white;"><asp:Label ID="PhoneNumber" runat="server" Text="Phone Number"></asp:Label></td>
         <td style="border:none;float:left;"><asp:TextBox onkeypress="return IsNumeric1(event);" ID="TextBox3" runat="server"></asp:TextBox>
         <br /><span ID="Span1" style="color: Red; display: none">* Input digits only</span><br /><span ID="error1" style="color: Red; display: none">* Input digits only</span></td>
    </tr>
    <tr>
        <td colspan="2" style="border:none;background:#800000;color:white;">
        <asp:Button Width="96px" Height="35px" ID="Button1" runat="server" Text="Update" onclick="Button1_Click" />
        </td>
    </tr>
    </table>
</asp:Content>
