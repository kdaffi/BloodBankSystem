<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HospitalRegister.aspx.cs" Inherits="BBS.HospitalRegister" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:Panel ID="Panel1" runat="server">
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label2" runat="server" Text="Label"><h2>New Hospital Registration</h2></asp:Label><br />
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
        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="register_click" />
    </div>
    </form>
    </asp:Panel>

    <asp:Panel ID="Panel2" runat="server">
    <form id="form2" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"><h2>New Donor Registration</h2></asp:Label><br />
        <asp:RadioButton ID="RadioButton3" AutoPostBack="true" GroupName="type" value="hospital" Text="New Hospital" runat="server" />
        <asp:RadioButton ID="RadioButton4" AutoPostBack="true" GroupName="type" value="donor" Checked="true" Text="New Donor" runat="server" /><br />
        <label>Name</label>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox><br />
        <label>Location</label>
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox><br />
        <label>Phone Number</label>
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox><br />
        <label>Address</label>
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox><br />
        <label>Postcode</label>
        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox><br />
        <label>Username</label>
        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox><br />
        <label>Password</label>
        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button2" runat="server" Text="Register" OnClick="register_click" />
    </div>
    </form>
    </asp:Panel>
</body>
</html>
