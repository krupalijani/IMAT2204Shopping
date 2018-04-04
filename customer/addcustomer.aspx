<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addcustomer.aspx.cs" Inherits="addcustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body style="height: 493px">
    <form id="form1" runat="server">
    <div>
    
<h2>Add Customer</h2>
    <div style="width: 358px; float: left; height: 1100px; margin: 33px 0px 0px 1px;">
   
        <p>
       
        <asp:Label ID="lblfname" runat="server" Text="First name"></asp:Label>
        <asp:TextBox ID="txtfname" runat="server"  style="margin-left:97px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtfname" ErrorMessage="*" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
   </p> 
             
            
       

    
        <p>
        <asp:Label ID="lbllname" runat="server" Text="Last name"></asp:Label>
        <asp:TextBox ID="txtlname" runat="server" style="margin-left:98px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtlname" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
     </p> 
            
            
        <div>
            <p>
        <asp:Label ID="lbldob" runat="server" Text="Date of Birth"></asp:Label>
        <asp:TextBox ID="txtdob" runat="server" style="margin-left:81px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtdob" ErrorMessage="*"  ForeColor="Red"></asp:RequiredFieldValidator>
</p>    
                </div>
          
         <div>
             <p>
        <asp:Label ID="lblemail" runat="server" Text="E-mail"></asp:Label>
        <asp:TextBox ID="txtemail" runat="server" style="margin-left:121px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtemail" ErrorMessage="*"  ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
                 </div> 
           
            <div>
                <p>
        <asp:Label ID="lblcountry" runat="server" Text="Country"></asp:Label>
        <asp:TextBox ID="txtcountry" runat="server" style="margin-left:111px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtcountry" ErrorMessage="*"  ForeColor="Red"></asp:RequiredFieldValidator> 
                    </p>
           </div>
            
         <div>
             <p>
        <asp:Label ID="lbladdress" runat="server" Text="Address"></asp:Label>
             <asp:TextBox ID="txtaddress" runat="server" TextMode="MultiLine" style="margin-left:109px" > </asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtaddress" ErrorMessage ="*"  ForeColor="Red"></asp:RequiredFieldValidator>   
         </p>
                 </div>
            
         <div>
             <p>

        <asp:Label ID="lblpnumber" runat="server" Text="Phone number"></asp:Label>
        <asp:TextBox ID="txtpnumber" runat="server" style="margin-left:73px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtpnumber" ErrorMessage="*"  ForeColor="Red"></asp:RequiredFieldValidator>
             </p>

         </div>
             
        
            <div>
                <p>
        <asp:Label ID="lblgender" runat="server" Text="Gender"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtGender" ErrorMessage ="*" ForeColor="Red"></asp:RequiredFieldValidator>
             </p>
                </div>
           
         
        
         <div>
             <p>
        <asp:Label ID="lblPcode" runat="server" Text="Post Code"></asp:Label>
        <asp:TextBox ID="txtPcode" runat="server" style="margin-left:101px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtPcode" ErrorMessage="*"  ForeColor="Red"></asp:RequiredFieldValidator>
              </p>
                 </div>
             
        

         <div>
             <p>
                 &nbsp;</p>
                 </div> 
            
        
              <div>
                      </div>
    
        <asp:Button ID="btnAddCustomer" runat="server" Text="Add Customer"  />
        <asp:Button ID="btncancel" runat="server" Text="Cancel" />
        <br />
        <br />
        <br />
 </div>
<div>


</div>


    </div>
    </form>
</body>
</html>
