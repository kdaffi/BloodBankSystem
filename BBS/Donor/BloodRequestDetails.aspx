<%@ Page Title="" Language="C#" MasterPageFile="~/Donor/DonorMaster.Master" AutoEventWireup="true" CodeBehind="BloodRequestDetails.aspx.cs" Inherits="BBS.Donor.BloodRequestDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="overflow:auto;">
<table><tr><td style="border:0;">
<table>
    <tr>
        <td colspan="2" class="header" style="height:40px; color:White;padding-right:60px;">Request Details</td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Hospital Name</td><td style="float:left;width:300px;"><asp:Label ID="hospitalname" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Blood Type</td><td style="float:left;width:300px;"><asp:Label ID="bloodtype" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Blood ID</td><td style="float:left;width:300px;"><asp:Label ID="bloodid" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Address</td><td style="float:left;width:300px;"><asp:Label ID="Label2" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Postcode</td><td style="float:left;width:300px;"><asp:Label ID="Label3" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Location</td><td style="float:left;width:300px;"><asp:Label ID="location" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>
    <tr>
        <td style="background:#800000;color:white;">Phone Number</td><td style="float:left;width:300px;"><asp:Label ID="phone" runat="server" ReadOnly="True"></asp:Label></td>
    </tr>

    <tr><td style="background:#800000;color:white;">Approval</td>
        <td style="float:left;width:300px;">
            <asp:DropDownList ID="DropDownList1" AutoPostBack="true" OnSelectedIndexChanged="approval" runat="server">
                <asp:ListItem Value="sel">---- SELECT ----</asp:ListItem>
                <asp:ListItem>Approve</asp:ListItem>
                <asp:ListItem>Reject</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>

    <tr><td style="background:#800000;color:white;">Date to make a donation</td>
        <td colspan="2"><cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></cc1:ToolkitScriptManager>
                        <asp:TextBox ID="txtDate" runat="server" Height="20px" Width="98px"></asp:TextBox>
                        <asp:ImageButton ID="imgPopup" ImageUrl="../images/calendar.png" ImageAlign="Bottom" runat="server" />
                        <cc1:CalendarExtender ID="Calendar1" PopupButtonID="imgPopup" runat="server" TargetControlID="txtDate" Format="dd/MM/yyyy"></cc1:CalendarExtender>
                        <asp:Label ID="Label4" Visible="false" runat="server" Text="Label"></asp:Label>
                        </td>
    </tr>
    <tr>
        <td colspan="2" style="border:none;background:#800000;color:white;"><asp:Button Width="96px" Height="35px" ID="Button1" runat="server" Text="Submit" OnClick="updatedata"/></td>
    </tr>

    

</table></td>

<td style="border:0;">
   <asp:ValidationSummary ID="ValidationSummary1" runat=server HeaderText="There were errors on the page:" />
   <asp:RequiredFieldValidator ControlToValidate="DropDownList1" ID="RequiredFieldValidator1" runat="server" Display="None" InitialValue="sel" ErrorMessage="You must select approval"></asp:RequiredFieldValidator>  
   <asp:RequiredFieldValidator ControlToValidate="txtDate" ID="RequiredFieldValidator3" runat="server" Display="None" ErrorMessage="You must field in donation date"></asp:RequiredFieldValidator>  
</td>

</tr></table></div>
</asp:Content>
