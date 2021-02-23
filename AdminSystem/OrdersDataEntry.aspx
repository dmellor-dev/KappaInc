<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
       <div>

           <asp:Label ID="lblOrderId" runat="server" Text="Order Id " width="157px"></asp:Label>
           <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox><br />
           <asp:Label ID="lblItemId" runat="server" Text="Item Id " width="157px"></asp:Label>
           <asp:TextBox ID="txtItemId" runat="server"></asp:TextBox><br />
           <asp:Label ID="lblOrderDate" runat="server" Text="Order Date " width="157px"></asp:Label>
           <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox><br />
           <asp:Label ID="lblDeliveryAddress" runat="server" Text="Delivery Address " width="157px"></asp:Label>
           <asp:TextBox ID="txtDeliveryAddress" runat="server"></asp:TextBox><br />
           <asp:Label ID="lblUnitPrice" runat="server" Text="Unit Price " width="157px"></asp:Label>
           <asp:TextBox ID="txtUnitPrice" runat="server"></asp:TextBox><br />
           <asp:Label ID="lblQuantity" runat="server" Text="Quantity " width="157px"></asp:Label>
           <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox><br />
           <asp:Label ID="lblProductCode" runat="server" Text="Product Code/SKU "></asp:Label>
           <asp:TextBox ID="txtProductCode" runat="server"></asp:TextBox><br />
           <asp:CheckBox ID="chkDispatched" runat="server" Text="Dispatched " /><br />
           <asp:CheckBox ID="chkActiv" runat="server" Text="Order Active "/><br />
           <asp:Label ID="lblError" runat="server" Text=""></asp:Label><br />
           <asp:Button ID="btnAccept" runat="server" Text="Accept" OnClick="btnAccept_Click" />
           <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
       </div>
      
   </form>
</body>
</html>
