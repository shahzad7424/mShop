<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="AsiaHospital.Start" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/CSS/Style1.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
</head>
<body>
    <form id="form1" runat="server" style="max-width:500px;margin:auto">
        <div class="container">
            <div class="logo">
        <h2 class="h2l">Login</h2>
                </div>
            <div class="inputfield">
        <div class="input-container">
            <i class="fa fa-user icon"></i>
            <asp:TextBox ID="TextBox1" class="input-field" runat="server"></asp:TextBox>
        </div>
        <div class="input-container">
    <i class="fa fa-key icon"></i>
    <asp:TextBox ID="TextBox2" class="input-field" TextMode="Password" runat="server"></asp:TextBox>
  </div>
        <asp:Button ID="Button1" runat="server" class="btn" Text="Login" />

                <h6 class="h6a">If You Don't Have Acount then </h6>
    </div>
            </div>


            </form>
  

</body>
</html>
