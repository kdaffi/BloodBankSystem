<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DonorRegister.aspx.cs" Inherits="BBS.DonorRegister" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButton ID="RadioButton1" AutoPostBack="true" GroupName="type" value="hospital" Checked="true" Text="New Hospital" runat="server" />
        <asp:RadioButton ID="RadioButton2" AutoPostBack="true" GroupName="type" value="donor" Text="New Donor" runat="server" /><br />
        <label>Name</label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <label>Location</label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <label>Phone Number</label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        <label>Address</label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        <label>Postcode</label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
        <label>Username</label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
        <label>Password</label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />
        <%--<asp:Button ID="Button1" runat="server" Text="Register" OnClick="register_click" />--%>
    </div>
    </form>

</body>
</html>
