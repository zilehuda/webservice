<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
        <asp:Label ID="lblText" runat="server" />
    </div>
        <div>
    <asp:gridview ID="gvEmp" runat="server"></asp:gridview>
    </div>
    </form>
</body>
</html>
