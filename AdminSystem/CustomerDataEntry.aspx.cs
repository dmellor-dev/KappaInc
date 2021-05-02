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

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        //create instance of the address class 
        clsCustomer AnCustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerNo;
        //variable to store the result of the find operation 
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerNo = Convert.ToInt32(txtCustomerNumber.Text);
        //find the record
        Found = AnCustomer.Find(CustomerNo);
        //if found 
        if(Found == true)
        {
            //display the values of the properties in the form
            txtCustomerName.Text = AnCustomer.CustomerName;
            txtCustomerEmail.Text = AnCustomer.CustomerEmail;
            txtCustomerBillingAddress.Text = AnCustomer.CustomerBillingAddress;
            txtCustomerShippingAddress.Text = AnCustomer.CustomerShippingAddress;
            txtDateWhenJoined.Text = AnCustomer.DateJoined.ToString();
            
        }
        else
        {
            lblError.Text = ("That is a invalid customer number");
        }
    }
}
