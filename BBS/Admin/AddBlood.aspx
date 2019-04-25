<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddBlood.aspx.cs" Inherits="BBS.Admin.AddBlood" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .drop
        { 
           margin-left:0px;
        }
        
    </style>

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
    <table border="1px" style="border-color:#800000;border-radius:5px;">
    <tr>
        <td colspan="2" style="background:#800000;color:white;">Add Blood</td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;"><asp:Label ID="Label1" runat="server" Text="Blood Type"></asp:Label></td>
        <td style="border:none;"><asp:DropDownList
        ID="DropDownList1" Width="135px" runat="server" name="blood" CssClass="drop">
        <asp:ListItem Selected="True" Value="blood">Select Blood Type</asp:ListItem>
        <asp:ListItem>A+</asp:ListItem>
        <asp:ListItem>A-</asp:ListItem>
        <asp:ListItem>B+</asp:ListItem>
        <asp:ListItem>B-</asp:ListItem>
        <asp:ListItem>O+</asp:ListItem>
        <asp:ListItem>O-</asp:ListItem>
        <asp:ListItem>AB+</asp:ListItem>
        <asp:ListItem>AB-</asp:ListItem>
    </asp:DropDownList></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;"><asp:Label ID="Label2" runat="server" Text="Availability"></asp:Label></td>
        <td style="border:none;"><asp:TextBox ID="availability" name="ava" runat="server" CssClass="drop" 
                Width="52px" onkeypress="return IsNumeric(event);"></asp:TextBox><asp:Label ID="Label3" runat="server" Text=" packs/100ml"></asp:Label>
                <br /><span ID="error" style="color: Red; display: none">* Input digits only</span></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;"><asp:Label ID="Label4" runat="server" Text="Expired Date"></asp:Label></td>
        <td style="border:none;">
     <asp:TextBox ID="txtDate" runat="server" Height="20px" Width="98px"></asp:TextBox>
    <asp:ImageButton ID="imgPopup" ImageUrl="../images/calendar.png" ImageAlign="Bottom"
        runat="server" />
    
    </td>
    </tr>
    <tr>
        <td colspan="2" style="border:none;background:#800000;color:white;">
            <asp:Button ID="Button1" runat="server" CssClass="drop" 
                OnClick="add_click" Text="Add" Width="96px" Height="35px"></asp:Button></td>
    </tr>
    </table><cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager><cc1:CalendarExtender ID="Calendar1" PopupButtonID="imgPopup" runat="server" TargetControlID="txtDate"
        Format="dd/MM/yyyy"></cc1:CalendarExtender><br />
        <asp:ValidationSummary ID="ValidationSummary1" runat=server HeaderText="There were errors on the page:" />
<asp:RequiredFieldValidator ControlToValidate="DropDownList1" ID="RequiredFieldValidator1" runat="server" Display="None" InitialValue="blood" ErrorMessage="You must select blood type"></asp:RequiredFieldValidator>
<asp:RequiredFieldValidator ControlToValidate="availability" ID="RequiredFieldValidator2" runat="server" Display="None" ErrorMessage="You must field in number of blood pack available"></asp:RequiredFieldValidator>
<asp:RequiredFieldValidator ControlToValidate="txtDate" ID="RequiredFieldValidator3" runat="server" Display="None" ErrorMessage="You must field in expired date"></asp:RequiredFieldValidator>
</asp:Content>
