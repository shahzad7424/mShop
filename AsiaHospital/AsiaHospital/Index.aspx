<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AsiaHospital.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/CSS/Style2.css" rel="stylesheet" />
 </head>
<body>
    <form id="form1" runat="server">
        <nav class="topnav">
            <h1>Hospital Information</h1>
      </nav>
        <nav class="navigation">
  <ul class="mainmenu">
    <div>
        <h3> Web Hospital</h3>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/kisspng-organization-company-business-united-states-global-eslimi-5ad146440b8dc4.7668403615236644520474.png" />
   <h2>Hospital Mangment DashBoard</h2>
        </div>
    <li> <asp:Button ID="Button1" runat="server" Text="Staff Records" /></li>
    <li> <asp:Button ID="Button2" runat="server" Text="Patients Appointment" />  </li>
    <li> <asp:Button ID="Button3" runat="server" CssClass="fa-folder" Text="Patients" />
      <ul class="submenu">
        <li> <asp:Button ID="Button4" runat="server" Text="Indoor" /> </li>
        <li> <asp:Button ID="Button5" runat="server" Text="Outdoor" /> </li>
      </ul>
    </li>
    <li> <asp:Button ID="Button6" runat="server" Text="Patients History" /></li>
      <li> <asp:Button ID="Button7" runat="server" Text="Create Recipte" /></li>
      <li> <asp:Button ID="Button8" runat="server" Text="Patient Data" /></li>
      <li> <asp:Button ID="Button9" runat="server" Text="Patient Reports" /></li>
    
  </ul>
</nav>
       

    </form>
</body>
</html>
