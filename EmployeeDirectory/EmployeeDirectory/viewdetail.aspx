<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewdetail.aspx.cs" Inherits="EmployeeDirectory.viewdetail" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
<style type="text/css" media="screen">
@import "style.css";
</style>

</head>
<body>
<form id="form1" runat="server">
<asp:PlaceHolder ID="phViewDetail" runat="server" Visible="true">
<fieldset>
<dl>
<dt>First name:</dt>
<dd><asp:Label ID="lblFName" runat="server" /></dd>
<dt>Last name:</dt>
<dd><asp:Label ID="lblLName" runat="server" /></dd>
<dt>Email:</dt>
<dd><asp:Label ID="lblEmail" runat="server" /></dd>
<dt></dt>
<dd><a href="Default.aspx">Back to employee directory</a></dd>
</dl>
</fieldset>
</asp:PlaceHolder>
<asp:PlaceHolder ID="phNoViewDetail" runat="server" Visible="false">
<p>No employee selected.</p>
</asp:PlaceHolder>
</form>
</body>
</html>
