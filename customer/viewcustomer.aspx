<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/customer/viewcustomer.aspx.cs" Inherits="viewcustomer"  %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            float: left;
            width: 693px;
            height: 425px;
        }
        .auto-style3 {
            position: absolute;
            top: 69px;
            z-index: 1;
            width: 163px;
            height: 20px;
            right: 1164px;
        }
        .auto-style5 {
            width: 673px;
            height: 271px;
            position: absolute;
            top: 121px;
            left: 17px;
            z-index: 1;
            right: 820px;
        }
        </style>
</head>
<body style="height: 493px">
    <form id="form1" runat="server">
    <div>
    
<h2>View Customer Details.</h2>
     <div style="margin:10px 0px 0px 0px;" class="auto-style2">

<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 9px; top: 93px; position: absolute"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server"  Text="Search" />
</p>

<p>
    &nbsp;</p>
         <p>
             &nbsp;</p>
         <p>
             &nbsp;</p>
         <p>
             &nbsp;</p>


         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="auto-style5" CellPadding="4" ForeColor="#333333" GridLines="None" >
             <AlternatingRowStyle BackColor="White" />
             <Columns>
                 <asp:BoundField HeaderText="First Name" />
                 <asp:BoundField HeaderText="Last Name" />
                 <asp:BoundField HeaderText="Email Address" />
                 <asp:BoundField HeaderText="Home Address" />
                 <asp:BoundField HeaderText="Date of birth" />
                 <asp:BoundField HeaderText="Gender" />
                 <asp:BoundField HeaderText="Postal code" />
                 <asp:ButtonField Text="deactivate" />
                 <asp:ButtonField Text="Activate" />
                 <asp:ButtonField Text="Edit" />
             </Columns>
             <EditRowStyle BackColor="#2461BF" />
             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
             <RowStyle BackColor="#EFF3FB" />
             <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
             <SortedAscendingCellStyle BackColor="#F5F7FB" />
             <SortedAscendingHeaderStyle BackColor="#6D95E1" />
             <SortedDescendingCellStyle BackColor="#E9EBEF" />
             <SortedDescendingHeaderStyle BackColor="#4870BE" />
         </asp:GridView>


         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>


</div>


    </div>
    </form>
</body>
</html>
