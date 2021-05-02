<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblCustomerNumber" runat="server" Text="Customer Number" width="170px"></asp:Label>
            <asp:TextBox ID="txtCustomerNumber" runat="server" width="245px"></asp:TextBox>
            <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" Text="Find" />
        </p>
        <p>
            <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name " width="170px"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server" width="245px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerEmail" runat="server" Text="Customer Email" width="170px"></asp:Label>
        <asp:TextBox ID="txtCustomerEmail" runat="server" width="245px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerBillingAddress" runat="server" Text="Customer Billing Address" width="170px"></asp:Label>
            <asp:TextBox ID="txtCustomerBillingAddress" runat="server" width="245px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerShippingAddress" runat="server" Text="Customer Shipping Address"></asp:Label>
        <asp:TextBox ID="txtCustomerShippingAddress" runat="server" width="245px"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateWhenJoined" runat="server" Text="Date When Joined" width="170px"></asp:Label>
            <asp:TextBox ID="txtDateWhenJoined" runat="server" Width="242px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chkAnyCurrentOrders" runat="server" Text="Any Current Orders" />
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" Height="26px" OnClick="btnOK_Click1" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
