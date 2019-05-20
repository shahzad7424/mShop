<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="HospitalManagment.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Home
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
   <asp:Panel>
     <asp:Menu ID="Menu1" runat="server" StaticDisplayLevels="3">
  <Items>
    <asp:MenuItem Text="File" Value="File">
      <asp:MenuItem Text="New" Value="New"></asp:MenuItem>
      <asp:MenuItem Text="Open" Value="Open"></asp:MenuItem>
    </asp:MenuItem>
    <asp:MenuItem Text="Edit" Value="Edit">
      <asp:MenuItem Text="Copy" Value="Copy"></asp:MenuItem>
      <asp:MenuItem Text="Paste" Value="Paste"></asp:MenuItem>
    </asp:MenuItem>
    <asp:MenuItem Text="View" Value="View">
      <asp:MenuItem Text="Normal" Value="Normal"></asp:MenuItem>
      <asp:MenuItem Text="Preview" Value="Preview"></asp:MenuItem>
    </asp:MenuItem>
  </Items>
</asp:Menu>
   </asp:Panel> 
</asp:Content>
