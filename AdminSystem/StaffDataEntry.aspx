<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffId" runat="server" Text="Staff ID" width="118px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtStaffId" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblFirstName" runat="server" Text="First Name" width="118px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblLastName" runat="server" Text="Last Name" width="118px"></asp:Label>
&nbsp;<asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address" width="118px"></asp:Label>
&nbsp;<asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblHomeAddress" runat="server" Text="Home Address" width="118px"></asp:Label>
&nbsp;<asp:TextBox ID="txtHomeAddress" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblStartDate" runat="server" Text="Start Date" width="118px"></asp:Label>
&nbsp;<asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkIsWorking" runat="server" Text="At Work?" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
