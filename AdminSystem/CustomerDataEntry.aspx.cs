using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   



    protected void btnOK_Click1(object sender, EventArgs e)
    {
        // this tells the viewer page what their value should be as text, converts any value to text/String
            clsCustomer AnCustomer = new clsCustomer();
            AnCustomer.CustomerNo = Int32.Parse(txtCustomerNumber.Text);
            AnCustomer.CustomerName = txtCustomerName.Text;
            AnCustomer.CustomerEmail = txtCustomerEmail.Text;
            AnCustomer.CustomerBillingAddress = txtCustomerBillingAddress.Text;
            AnCustomer.CustomerShippingAddress = txtCustomerShippingAddress.Text;
            AnCustomer.DateJoined = Convert.ToDateTime(txtDateWhenJoined.Text);
        AnCustomer.CurrentOrder = chkAnyCurrentOrders.Checked;
            Session["AnCustomer"] = AnCustomer;
            //this navigates to the viewer page
            Response.Redirect("CustomerViewer.aspx");
        }
    }
