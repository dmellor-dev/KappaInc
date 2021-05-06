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
        clsCustomer AnCustomer = new clsCustomer();
        string CustomerName = txtCustomerName.Text;
        string CustomerEmail = txtCustomerEmail.Text;
        string CustomerBillingAdress = txtCustomerBillingAddress.Text;
        string CustomerShippingAdress = txtCustomerShippingAddress.Text;
        string DateWhenJoined = txtDateWhenJoined.Text;
        string Error = "";
        Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerShippingAdress, CustomerBillingAdress, DateWhenJoined);
        if(Error == "")
 {
            AnCustomer.CustomerName = CustomerName;
            AnCustomer.CustomerName=CustomerEmail;
            AnCustomer.CustomerShippingAddress = CustomerShippingAdress;
            AnCustomer.CustomerBillingAddress = CustomerBillingAdress;
            AnCustomer.DateWhenJoined = Convert.ToDateTime(DateWhenJoined);
            Session["AnCustomer"] = AnCustomer;
            Response.Write("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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
            txtDateWhenJoined.Text = AnCustomer.DateWhenJoined.ToString();
            
        }
        else
        {
            lblError.Text = ("That is a invalid customer number");
        }
    }
}
