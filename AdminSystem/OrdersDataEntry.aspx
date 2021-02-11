<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
       <div>

           <asp:Label ID="lblAddressNo" runat="server" Text="Address Number"></asp:Label>
           <asp:TextBox ID="txtAddressNumber" runat="server"></asp:TextBox><br />
           <asp:Label ID="lblHouseNumber" runat="server" Text="House Number "></asp:Label>
           <asp:TextBox ID="txtHouseNumber" runat="server"></asp:TextBox><br />
           <asp:Label ID="lblStreet" runat="server" Text="Street "></asp:Label>
           <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox><br />
           <asp:Label ID="lblTown" runat="server" Text="Town "></asp:Label>
           <asp:TextBox ID="txtTown" runat="server"></asp:TextBox><br />
           <asp:Label ID="lblPostcode" runat="server" Text="Postcode "></asp:Label>
           <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox><br />
           <asp:Label ID="lblCounty" runat="server" Text="County "></asp:Label>
           <asp:TextBox ID="txtCounty" runat="server"></asp:TextBox><br />
           <asp:Label ID="lblDateAdded" runat="server" Text="Date Added "></asp:Label>
           <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox><br />
       </div>
           
      
   </form>
</body>
</html>
