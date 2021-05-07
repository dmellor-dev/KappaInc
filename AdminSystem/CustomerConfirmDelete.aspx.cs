using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 CustomerNo;   

    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ThisCustomer.Find(CustomerNo);
        Customers.Delete();
        Response.Redirect("CustomerList.aspx");
    }
}