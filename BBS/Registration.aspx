<%@ Page Title="" Language="C#" MasterPageFile="~/Style.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="BBS.Registration" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
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


    <script type="text/javascript">
        var specialKeys = new Array();
        specialKeys.push(8); //Backspace
        function IsNumeric1(e) {
            var keyCode = e.which ? e.which : e.keyCode
            var ret = ((keyCode >= 48 && keyCode <= 57) || specialKeys.indexOf(keyCode) != -1);
            document.getElementById("error1").style.display = ret ? "none" : "inline";
            return ret;
        }
    </script>

    <script type="text/javascript">
        function SelectDate(e) {
            var PresentDay = new Date();
            var dateOfBirth = e.get_selectedDate();
            var months = (PresentDay.getMonth() - dateOfBirth.getMonth() + (12 * (PresentDay.getFullYear() - dateOfBirth.getFullYear())));
            document.getElementById("Label1").InnerHTML = Math.round(months / 12);
        }            
    </script>

    <script type="text/javascript">
        var specialKeys = new Array();
        specialKeys.push(8); //Backspace
        function IsNumeric2(e) {
            var keyCode = e.which ? e.which : e.keyCode
            var ret = ((keyCode >= 48 && keyCode <= 57) || specialKeys.indexOf(keyCode) != -1);
            document.getElementById("error2").style.display = ret ? "none" : "inline";
            return ret;
        }
    </script>

    <script type="text/javascript">
        var specialKeys = new Array();
        specialKeys.push(8); //Backspace
        function IsNumeric3(e) {
            var keyCode = e.which ? e.which : e.keyCode
            var ret = ((keyCode >= 48 && keyCode <= 57) || specialKeys.indexOf(keyCode) != -1);
            document.getElementById("error3").style.display = ret ? "none" : "inline";
            return ret;
        }
    </script>

    <script type="text/javascript">
        var specialKeys = new Array();
        specialKeys.push(8); //Backspace
        function IsNumeric4(e) {
            var keyCode = e.which ? e.which : e.keyCode
            var ret = ((keyCode >= 48 && keyCode <= 57) || specialKeys.indexOf(keyCode) != -1);
            document.getElementById("error4").style.display = ret ? "none" : "inline";
            return ret;
        }
    </script>

    <script>
        jQuery('.validatedForm').validate({
            rules : {
                password : {
                    minlength : 5
                },
                password_confirm : {
                    minlength : 5,
                    equalTo : "#password"
                }
            }
    </script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="select" Checked="true" AutoPostBack="true" Text="Hospital" />
    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="select" AutoPostBack="true" Text="Blood Donor" /><br /><br />
    <asp:Panel ID="hospitalpanel" runat="server">
    
        <table border="1px" style="border-color:#800000;border-radius:5px;">
                <tr>
                
                        
                    <th colspan="2">
                        New Hospital Registration</th>
                    <tr>
                        <td style="background:#800000;color:white;">
                            Hospital Name</td>
                        <td style="width:300px;border:none;">
                            <asp:TextBox Width="300px" ID="TextBox1" runat="server"></asp:TextBox>
                            
                        </td>
                    </tr>
                    <tr>
                        <td style="background:#800000;color:white;">
                            Address</td>
                        <td style="width:300px;border:none;">
                            <asp:TextBox Width="300px" ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="background:#800000;color:white;">
                            Postcode</td>
                        <td style="width:300px;border:none;">
                            <asp:TextBox ID="TextBox3" Width=100 style="float:left;" runat="server" ondrop="return false;" 
                                onkeypress="return IsNumeric1(event);" onpaste="return false;" 
                                MaxLength="6"></asp:TextBox>
                                
                                <br />
                            <span ID="error1" style="color: Red; display: none">* Input digits only</span>
                        </td>
                    </tr>
                    <tr>
                        <td style="background:#800000;color:white;">
                            State</td>
                        <td style="float:left;border:none;">
                            <asp:DropDownList ID="DropDownList1" runat="server">
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
                        <td style="background:#800000;color:white;">
                            Phone Number</td>
                        <td style="float:left;border:none;">
                            <asp:TextBox ID="TextBox4" runat="server" MaxLength="10" ondrop="return false;" 
                                onkeypress="return IsNumeric(event);" onpaste="return false;"></asp:TextBox>
                                
                            <br />
                            <span ID="error" style="color: Red; display: none">* Input digits only</span>
                        </td>
                    </tr>
                </tr>
                <tr>
                    <td style="background:#800000;color:white;">Username</td>
                    <td style="float:left;border:none;">
                        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                       
                    </td>
                </tr>
                <tr>
                    <td style="background:#800000;color:white;">Password</td>
                    <td style="float:left;border:none;">
                        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                       
                    </td>
                </tr>
                <tr style="height:55px;">
                    <td colspan="2" style="background:#800000;">
                        <asp:Button Width="96px" Height="35px" ID="Button1" runat="server" 
                            Text="Register" CausesValidation="true" onclick="Button1_Click" />
                            <asp:Button Width="96px" CausesValidation="false" Height="35px" ID="Button3" runat="server" 
                            Text="Cancel" onclick="back" />
                    </td>
                </tr>
        </table><br />
        <asp:ValidationSummary ID="ValidationSummary1" runat=server HeaderText="There were errors on the page:" />
        <asp:RequiredFieldValidator ControlToValidate="TextBox1" ID="RequiredFieldValidator1" runat="server" Display="None" ErrorMessage="You must field in Hospital Name"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="TextBox2" ID="RequiredFieldValidator2" runat="server" Display="None" ErrorMessage="You must field in your Address"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="TextBox3" ID="RequiredFieldValidator3" runat="server" Display="None" ErrorMessage="You must field in Postcode"></asp:RequiredFieldValidator>  
        <asp:RequiredFieldValidator ControlToValidate="DropDownList1" ID="RequiredFieldValidator4" runat="server" InitialValue="state" Display="None" ErrorMessage="You must select your State"></asp:RequiredFieldValidator>   
        <asp:RequiredFieldValidator ControlToValidate="TextBox4" ID="RequiredFieldValidator5" runat="server" Display="None" ErrorMessage="You must field in Contact Number"></asp:RequiredFieldValidator>   
        <asp:RequiredFieldValidator ControlToValidate="TextBox12" ID="RequiredFieldValidator6" runat="server" Display="None" ErrorMessage="You must field in Username"></asp:RequiredFieldValidator>  
        <asp:RequiredFieldValidator ControlToValidate="TextBox13" ID="RequiredFieldValidator7" runat="server" Display="None" ErrorMessage="You must field in Password"></asp:RequiredFieldValidator>                        
    </asp:Panel>
  
    <asp:Panel ID="donorpanel" runat="server">
    <panel style="float:right;margin-right:100px;position:relative;">
        <asp:ValidationSummary ID="ValidationSummary2" runat=server HeaderText="There were errors on the page:" />
        <asp:RequiredFieldValidator ControlToValidate="TextBox5" ID="RequiredFieldValidator8" runat="server" Display="None" ErrorMessage="You must field in your Name"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="TextBox9" ID="RequiredFieldValidator9" runat="server" Display="None" ErrorMessage="You must field in IC Number"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="txtDate" ID="RequiredFieldValidator10" runat="server" Display="None" ErrorMessage="You must field in Date of Birth"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="TextBox6" ID="RequiredFieldValidator11" runat="server" Display="None" ErrorMessage="You must field in Address"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="TextBox7" ID="RequiredFieldValidator12" runat="server" Display="None" ErrorMessage="You must field in Postcode"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="DropDownList2" ID="RequiredFieldValidator13" runat="server" Display="None" InitialValue="state" ErrorMessage="You must select your State"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="TextBox8" ID="RequiredFieldValidator14" runat="server" Display="None" ErrorMessage="You must field in your phone number"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="DropDownList4" ID="RequiredFieldValidator15" runat="server" Display="None" InitialValue="blood" ErrorMessage="You must select your Blood Type"></asp:RequiredFieldValidator>
         <asp:RequiredFieldValidator ControlToValidate="TextBox10" ID="RequiredFieldValidator16" runat="server" Display="None" ErrorMessage="You must field in Username"></asp:RequiredFieldValidator>
          <asp:RequiredFieldValidator ControlToValidate="TextBox11" ID="RequiredFieldValidator17" runat="server" Display="None" ErrorMessage="You must field in Password"></asp:RequiredFieldValidator>
    </panel>
        
        <table border="1px" style="border-color:#800000;border-radius:5px;">
                <tr>
                    <th colspan="2">
                        New Donor Registration</th>
                    <tr>
                        <td style="background:#800000;color:white;">
                            Donor Name</td>
                        <td style="width:300px;border:none;">
                            <asp:TextBox Width="300px" ID="TextBox5" runat="server"></asp:TextBox>
                           
                        </td>
                    </tr>
                    <tr>
                        <td style="background:#800000;color:white;">IC Number</td>
                        <td style="float:left;border:none;"">
                            <asp:TextBox ID="TextBox9" runat="server" ondrop="return false;" 
                                onkeypress="return IsNumeric2(event);" onpaste="return false;" MaxLength="12" AutoPostBack="true" OnTextChanged="getgender"></asp:TextBox>
                           
                            <span ID="error2" style="color: Red; display: none">* Input digits only</span>
                        </td>
                    </tr>
                     <tr>
                        <td style="background:#800000;color:white;">Gender</td>
                        <td style="float:left;border:none;"">
                            <asp:Label ID="Label2" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="background:#800000;color:white;">Date of Birth</td>
                        <td style="float:left;border:none;""><cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></cc1:ToolkitScriptManager>
                        <asp:TextBox ID="txtDate" runat="server" Height="20px" Width="98px"></asp:TextBox>
                        <asp:ImageButton ID="imgPopup" ImageUrl="../images/calendar.png" ImageAlign="Bottom" runat="server" />
                        <cc1:CalendarExtender OnClientDateSelectionChanged="SelectDate" ID="Calendar1" PopupButtonID="imgPopup" runat="server" TargetControlID="txtDate" Format="dd/MM/yyyy"></cc1:CalendarExtender>
                      </td>
                    </tr>
                    <tr>
                        <td style="background:#800000;color:white;">Age</td>
                        <td style="float:left;border:none;""><div id="test"><asp:Label ID="Label1" runat="server"></asp:Label></div></td>
                    </tr>
                    
                    <tr>
                        <td style="background:#800000;color:white;">
                            Address</td>
                        <td style="width:300px;border:none;">
                            <asp:TextBox Width="300px" ID="TextBox6" runat="server"></asp:TextBox>
                           
                        </td>
                    </tr>
                   
                    <tr>
                        <td style="background:#800000;color:white;">
                            Postcode</td>
                        <td style="width:300px;border:none;">
                            <asp:TextBox ID="TextBox7" Width=100 style="float:left;" runat="server" ondrop="return false;" 
                                onkeypress="return IsNumeric3(event);" onpaste="return false;" 
                                MaxLength="6"></asp:TextBox>
                              
                            <span ID="error3" style="color: Red; display: none">* Input digits only</span>
                        </td>
                    </tr>
                    <tr>
                        <td style="background:#800000;color:white;">
                            State</td>
                        <td style="float:left;border:none;">
                            <asp:DropDownList ID="DropDownList2" runat="server">
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
                        <td style="background:#800000;color:white;">
                            Phone Number</td>
                        <td style="float:left;border:none;">
                            <asp:TextBox ID="TextBox8" runat="server" MaxLength="10" ondrop="return false;" 
                                onkeypress="return IsNumeric4(event);" onpaste="return false;"></asp:TextBox>
                          
                            <span ID="error4" style="color: Red; display: none">* Input digits only</span>
                        </td>
                    </tr>
                    <tr>
                        <td style="background:#800000;color:white;">Blood Type</td>
                        <td style="float:left;border:none;"">
                            <asp:DropDownList Width="135px" ID="DropDownList4" runat="server">
                                <asp:ListItem Selected="True" Value="blood">Select Blood Type</asp:ListItem>
                                <asp:ListItem>A+</asp:ListItem>
                                <asp:ListItem>A-</asp:ListItem>
                                <asp:ListItem>B+</asp:ListItem>
                                <asp:ListItem>B-</asp:ListItem>
                                <asp:ListItem>O+</asp:ListItem>
                                <asp:ListItem>O-</asp:ListItem>
                                <asp:ListItem>AB+</asp:ListItem>
                                <asp:ListItem>AB-</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td style="background:#800000;color:white;">Medical History</td>
                        <td style="border:none;">
                            <asp:CheckBox ID="CheckBox1" Text="Syphilis" style="float:left;" runat="server" /><br />
                            <asp:CheckBox ID="CheckBox2" Text="Malaria" style="float:left;" runat="server" /><br />
                            <asp:CheckBox ID="CheckBox3" Text="Filaria" style="float:left;" runat="server" /><br />
                            <asp:CheckBox ID="CheckBox5" Text="Diabetes" style="float:left;" runat="server" /><br />
                            <asp:CheckBox ID="CheckBox4" Text="HIV / Aids" style="float:left;" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td style="background:#800000;color:white;">Username</td>
                        <td style="border:none;">
                            <asp:TextBox ID="TextBox10" style="float:left;" runat="server"></asp:TextBox>
                            
                        </td>
                    </tr>
                    <tr>
                        <td style="background:#800000;color:white;">Password</td>
                        <td style="border:none;">
                            <asp:TextBox ID="TextBox11" style="float:left;" runat="server"></asp:TextBox>
                           
                        </td>
                    </tr>
                </tr>
                <tr>
                    <td colspan="2" style="background:#800000;">
                        <asp:Button Width="96px" Height="35px" ID="Button2" runat="server" 
                            Text="Register" CausesValidation="true" onclick="Button2_Click" />
                            <asp:Button Width="96px" Height="35px" ID="Button4" runat="server" 
                            Text="Cancel" CausesValidation="false" onclick="back" />
                    </td>
                </tr></table>
                
    </asp:Panel>
         <script type="text/javascript">
             function SelectDate(e) {
                 var PresentDay = new Date();
                 var dateOfBirth = e.get_selectedDate();
                 var months = (PresentDay.getMonth() - dateOfBirth.getMonth() + (12 * (PresentDay.getFullYear() - dateOfBirth.getFullYear())));
                 document.getElementById("test").innerHTML = Math.round(months / 12) + " years old";
             }            
    </script>
</asp:Content>
