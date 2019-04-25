<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ITSP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="X-UA-Compatible" content="IE=8, IE=9"/> 
    <title></title>
    <link rel="shortcut icon" href="~/favicon.ico" /> 
    <link rel="stylesheet" type="text/css" href="~/Styles/loginstyle/LoginPage.css" />
    <script src="~/Styles/loginstyle/LoginPage.js" type="text/jscript"></script>
</head>
<body>
     <asp:Label class="labeltop" ID="lblMessage" runat="server" Text=""></asp:Label>
     <div class="container">
			<section class="main">
				<form class="form-2" runat="server">
					<img alt="loginlogo" class="login2" src="../Styles/loginstyle/1.png" />
					<p class="float" runat="server">
                        <asp:TextBox ID="txtUsername" runat="server" Value="Employee ID" OnBlur="if(this.value=='')this.value='Employee ID'" onFocus="if(this.value=='Employee ID')this.value='' "></asp:TextBox>
                        <asp:RequiredFieldValidator InitialValue="Employee ID" ControlToValidate="txtUsername" ID="RequiredFieldValidator1" runat="server" ErrorMessage="*EmployeeID required" cssClass="val"></asp:RequiredFieldValidator>
					</p>
					<p class="float">
                        <asp:TextBox ID="txtPassword" runat="server" Value="Password" 
                            onBlur="if(this.value=='')this.value='Password'" 
                            onFocus="if(this.value=='Password')this.value='' " TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator InitialValue="Password" ControlToValidate="txtPassword" ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Password required" CssClass="val"></asp:RequiredFieldValidator>
					</p>
                    
                    
                    
					<p class="clearfix">
                        <asp:CheckBox ID="AdminCheck" Text="&nbsp;Administrator" runat="server" CssClass="checkbox"></asp:CheckBox>
                        <asp:Button type="submit" ID="btnLogin" runat="server" Text="Login" 
                            onclick="btnLogin_Click" CssClass="checkbox"></asp:Button>
					</p>
				</form>​​
			</section>
			
        </div>
		<!-- jQuery if needed -->
		
</body>
</html>
