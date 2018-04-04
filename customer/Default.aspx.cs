using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;





public partial class _Default :  System.Web.UI.Page
{
    //page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }

    }

    void DisplayCustomers()
    {
        //create an instance of the customer collection
        Class_Library.clsCustomerCollection Customers = new Class_Library.clsCustomerCollection();
        //set the data source to the list of customers in the collection
        
    }
}
