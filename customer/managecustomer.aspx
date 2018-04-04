<%@ Page Language="C#" AutoEventWireup="true" CodeFile="managecustomer.aspx.cs" Inherits="customer_managecustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 489px">
    <form id="form1" runat="server">
    <div>
    
  <h2> Customer Management:<asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 202px; top: 65px; position: absolute; right: 1056px;" Text="Add customers" />
      <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 369px; top: 65px; position: absolute" Text="View All Customers" />
        </h2>

    </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnView" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 608px; top: 66px; position: absolute" Text="Update Customer Information" />
        <asp:ListBox ID="ListBox1" runat="server" Height="313px" Width="775px"></asp:ListBox>
        <p>
            <asp:Label ID="Label1" runat="server" Text="[Error]"></asp:Label>
        </p>
    </form>
</body>
</html>
