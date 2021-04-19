<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrdersList" runat="server" Height="500px" Width="460px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Image ID="Image1" runat="server" Height="100px" ImageAlign="Top" ImageUrl="~/Capture.PNG" style="margin-bottom: 0px" Width="200px" />
        </div>
    </form>
</body>
</html>
