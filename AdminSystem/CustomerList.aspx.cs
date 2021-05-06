using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomersList.DataSource = Customers.CustomerList;
        lstCustomersList.DataValueField = "CustomerNo";
        lstCustomersList.DataTextField = "CustomerShippingAddress";
        lstCustomersList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record 
        Session["CustomerNo"] = -1;
        Response.Redirect("AnCustomer.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerNo;

        if(lstCustomersList.SelectedIndex != -1)
            {
            CustomerNo = Convert.ToInt32(lstCustomersList.SelectedValue);
            Session["CustomerNo"] = CustomerNo;
            Response.Redirect("AnCustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}