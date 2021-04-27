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
            <asp:Image ID="Image1" runat="server" Height="100px" ImageAlign="Top" ImageUrl="~/Capture.PNG" style="margin-bottom: 0px" Width="200px" />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <br />
            <asp:Label ID="lblProductCode" runat="server" Text="Enter a product code"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </div>

        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
            </p>

    </form>
</body>
</html>
