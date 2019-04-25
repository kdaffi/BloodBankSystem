<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddAdmin.aspx.cs" Inherits="BBS.Admin.AddAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border="1px" style="border-color:#800000;border-radius:5px;">
        <tr>
        <td colspan="2" style="background:#800000;color:white;">Add New Admin</td>
        </tr>
        <tr>
            <td style="background:#800000;color:white;"><asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td>
            <td style="border:none;"> <asp:TextBox ID="name" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="background:#800000;color:white;"><asp:Label ID="Username" runat="server" Text="Username"></asp:Label></td>
            <td style="border:none;"> <asp:TextBox ID="usr" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="background:#800000;color:white;"><asp:Label ID="Password" runat="server" Text="Password"></asp:Label></td>
            <td style="border:none;"> <asp:TextBox ID="pwd" runat="server"></asp:TextBox></td>
        </tr>
        <tr><td colspan="2" style="border:none;background:#800000;color:white;"><asp:Button ID="add" runat="server" Text="Add" 
                onclick="add_Click" Width="96px" Height="35px" /></td></tr>
    </table><br />
    <asp:ValidationSummary ID="ValidationSummary1" runat=server HeaderText="There were errors on the page:" />
<asp:RequiredFieldValidator ControlToValidate="name" ID="RequiredFieldValidator1" runat="server" Display="None" ErrorMessage="You must field in name"></asp:RequiredFieldValidator>
<asp:RequiredFieldValidator ControlToValidate="usr" ID="RequiredFieldValidator2" runat="server" Display="None" ErrorMessage="You must field in username"></asp:RequiredFieldValidator>
<asp:RequiredFieldValidator ControlToValidate="pwd" ID="RequiredFieldValidator3" runat="server" Display="None" ErrorMessage="You must field in password"></asp:RequiredFieldValidator>
</asp:Content>
