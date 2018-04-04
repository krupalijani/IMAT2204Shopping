using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class customer_managecustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/customer/viewcustomer.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/customer/editprofile.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("~/customer/managecustomer.aspx");
    }
}