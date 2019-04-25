<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BBS.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<meta http-equiv="X-UA-Compatible" content="IE=8,IE=Edge,IE=9,IE=10,chrome=1"/>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Blood Bank System</title>
    <link rel="stylesheet" type="text/css" href="~/Styles/loginstyle/LoginPage.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="labeltop">
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    </div>
    <div class="logo">
        <img class="pic" alt="loginlogo" src="../Styles/loginstyle/1.png"/>
    </div>
    <div class="form" style="height: 112px">
        
        <asp:TextBox class="user" autocomplete="off" ID="txtUsername" runat="server" Value="Username" OnBlur="if(this.value=='')this.value='Username'" onFocus="if(this.value=='Username')this.value=''" MaxLength="20" ViewStateMode="Inherit"></asp:TextBox>
        <asp:RequiredFieldValidator InitialValue="Username" ControlToValidate="txtUsername" ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Username required" CssClass="valemployee"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox autocomplete="off" class="password" ID="txtPassword" runat="server" value="hospital123"
            onBlur="if(this.value=='')this.value='Password'" 
            onFocus="if(this.value=='Password')this.value='' " TextMode="Password"
            MaxLength="19" ></asp:TextBox>

        <asp:Button ID="ImageButton1" CssClass="showpwd" OnClick="showpwd_Click" runat="server"></asp:Button>
        <asp:Button ID="Button1" Visible="false" OnClick="showpwd2_Click" CssClass="showpwd2" runat="server"></asp:Button>
        <asp:RequiredFieldValidator InitialValue="Password" ControlToValidate="txtPassword" ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Password required" CssClass="valpwd"></asp:RequiredFieldValidator>
        <asp:Button type="submit" ID="btnLogin" runat="server" CssClass="button" OnClick="loginclick"></asp:Button>
        <a class="regnew" href="Registration.aspx" shape="circle"><b>REGISTER</b></a>
        <asp:Label ID="Label1" CssClass="labelbottom" runat="server" Text="Copyright © 2014 Blood Bank System|FYP.MKhirdaffi"></asp:Label>
    </div>
    </form>
</body>
</html>
