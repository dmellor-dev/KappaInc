using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();

        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //this print out the values that were inputted in the customer data entry
        Response.Write(AnCustomer.CustomerNo);
        Response.Write(AnCustomer.CustomerName);
        Response.Write(AnCustomer.CustomerEmail);
        Response.Write(AnCustomer.CustomerBillingAddress);
        Response.Write(AnCustomer.CustomerShippingAddress);
        Response.Write(AnCustomer.DateJoined);
        Response.Write(AnCustomer.CurrentOrder);
    }
}