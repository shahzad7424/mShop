<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Resturant.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .container {
            height: 179px;
            width: 574px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class ="container">
            <asp:TextBox ID="txtusername" class="input100" placeholder="Type your username"  runat="server"></asp:TextBox>
            <asp:TextBox ID="txtpassword" TextMode="Password" class="input100" placeholder="Type your password"  runat="server"></asp:TextBox>
            <asp:Button ID="btnlogin" class="login100-form-btn" runat="server" Text="Login" onclick="btnlogin_Click" />
        </div>
    </form>
</body>
</html>
