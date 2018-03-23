using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class addcustomer : System.Web.UI.Page
{
    //variable  to store the CustomerID
    Int32 CustomerID;
        //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the customerID from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //if we are not adding a new record
            if (CustomerID != -1)
            {
                //update the fields on the page with the data from the record
                DisplayCustomer();
            }
            
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the customer class
        clsCustomer AllCustomer = new clsCustomer();
        //find the record we want to display
        AllCustomer.Find(CustomerID);
        //display the customer FirstName
        txtfname.Text = AllCustomer.FirstName;
        //display the customer LastName
        txtlname.Text = AllCustomer.LastName;
        //display the customer gender
        txtGender.Text = AllCustomer.Gender;
        //display the customer email address
        txtemail.Text = AllCustomer.EmailAddress;
        //display the customer address
        txtaddress.Text = AllCustomer.HomeAddress;
        //display the customer phone number
        txtpnumber.Text = AllCustomer.PhoneNo;
        //display the customer DOB
        txtdob.Text = AllCustomer.DOB.ToString();
    }
}