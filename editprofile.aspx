<%@ Page Language="C#" AutoEventWireup="true" CodeFile="editprofile.aspx.cs" Inherits="customer_editprofile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>Edit Customer Details.</h2>
        <div style="width: 393px; float: left; height: 1100px; margin: 33px 0px 0px 1px;">
            <p>
                <asp:Label ID="lblfname" runat="server" Text="First name"></asp:Label>
                <asp:TextBox ID="txtfname" runat="server"  style="margin-left:100px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BackColor="White" ControlToValidate="txtfname" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="lbllname" runat="server" Text="Last name"></asp:Label>
                <asp:TextBox ID="txtlname" runat="server" style="margin-left:102px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtlname" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </p>
            <div>
                <p>
                    <asp:Label ID="lblemail" runat="server" Text="E-mail"></asp:Label>
                    <asp:TextBox ID="txtemail" runat="server" style="margin-left:126px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtemail" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </p>
            </div>
            <div>
                <p>
                    <asp:Label ID="lbladdress" runat="server" Text="Home Address"></asp:Label>
                    <asp:TextBox ID="txtaddress" runat="server" style="margin-left:72px" TextMode="MultiLine"> </asp:TextBox>
                </p>
            </div>
            <div>
                <p>
                    <asp:Label ID="lblpnumber" runat="server" Text="Phone number"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtpnumber" runat="server" style="margin-left:49px; margin-bottom: 0px;"></asp:TextBox>
                </p>
            </div>
            <div>
             
        

         <div>
             <p>
        <asp:Label ID="lbloldpassword" runat="server" Text="Old Password"></asp:Label>
        <asp:TextBox ID="txtoldpassword" runat="server" TextMode="Password" style="margin-left:78px"></asp:TextBox>
            
             </p>
                 </div> 
            <p>
                 <asp:Label ID="lblnewpassword" runat="server" Text="New Password"></asp:Label>
        <asp:TextBox ID="txtnewpassword" runat="server" TextMode="Password" style="margin-left:70px"></asp:TextBox>
            </p>
        
              <div>
                  <p>
        <asp:Label ID="lblcnewpassword" runat="server" Text="Confirm new password"></asp:Label>
        <asp:TextBox ID="txtcnewpassword" runat="server" TextMode="Password" style="margin-left:23px"></asp:TextBox>
              </p>
                      </div>
    
        <asp:Button ID="btnsubmit" runat="server" Text="Submit" />
        <asp:Button ID="btncancel" runat="server" Text="Cancel" />
        <br />
            </div>
        </div>
    
    </div>
    </form>
</body>
</html>
