<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblItemID" runat="server" Text="Item Identification Number"></asp:Label>
            <asp:TextBox ID="txtItemID" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="ItemName" runat="server" Text="Item Name" width="162px"></asp:Label>
        <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="ItemType" runat="server" Text="Item Type" width="162px"></asp:Label>
        <asp:TextBox ID="txtItemType" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="StockQuantity" runat="server" Text="Stock Quantity" width="162px"></asp:Label>
        <asp:TextBox ID="txtStockQuantity" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Price" runat="server" Text="Price" width="162px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Available" runat="server" Text="Available" width="162px"></asp:Label>
        <asp:CheckBox ID="chkAvailable" runat="server" Text=" " />
        <br />
        <asp:Label ID="Supplier" runat="server" Text="Supplier" width="162px"></asp:Label>
        <asp:TextBox ID="txtSupplier" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="NextRestock" runat="server" Text="Date Of Next Restock" width="162px"></asp:Label>
        <asp:TextBox ID="txtNextRestock" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click1" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
