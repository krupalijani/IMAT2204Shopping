<%@ Page Language="C#" AutoEventWireup="true" CodeFile="managecustomer.aspx.cs" Inherits="customer_managecustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
  <h2> Customer Management:<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 202px; top: 65px; position: absolute" Text="Add customers" />
      <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 369px; top: 65px; position: absolute" Text="View customers details" />
        </h2>

    </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 608px; top: 66px; position: absolute" Text="Edit customer profile" />
    </form>
</body>
</html>
