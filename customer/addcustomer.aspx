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
            <asp:radiobuttonlist id="rgender"   runat="server"  style="margin-left:100px" repeatDirection="Horizontal"  >
       <asp:listitem Value="a">Female</asp:listitem>
       <asp:listitem Value="b">Male</asp:listitem>
                <asp:ListItem Value ="c">Others</asp:ListItem>
</asp:radiobuttonlist>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="rgender" ErrorMessage ="*" ForeColor="Red"></asp:RequiredFieldValidator>
             </p>
                </div>
           
         
        
         <div>
             <p>
        <asp:Label ID="lbluname" runat="server" Text="username"></asp:Label>
        <asp:TextBox ID="txtuname" runat="server" style="margin-left:101px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtuname" ErrorMessage="*"  ForeColor="Red"></asp:RequiredFieldValidator>
              </p>
                 </div>
             
        

         <div>
             <p>
        <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtpass" runat="server" TextMode="Password" style="margin-left:98px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtpass" ErrorMessage="*"  ForeColor="Red"></asp:RequiredFieldValidator>
             </p>
                 </div> 
            
        
              <div>
                  <p>
        <asp:Label ID="lblcpassword" runat="server" Text="Confirm password"></asp:Label>
        <asp:TextBox ID="txtcpass" runat="server" TextMode="Password" style="margin-left:46px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtcpass" ErrorMessage="*"  ForeColor="Red"></asp:RequiredFieldValidator>
          <asp:CompareValidator id="Compare1" ControlToValidate="txtpass" ControlToCompare="txtcpass" Type="String" ErrorMessage ="Password does not match"  ForeColor="Red" runat="server"/>
              </p>
                      </div>
    
        <asp:Button ID="btnsubmit" runat="server" Text="Submit"  />
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
