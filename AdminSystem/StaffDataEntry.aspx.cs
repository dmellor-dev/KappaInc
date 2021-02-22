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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff StaffMember = new clsStaff();
        //capture a first name
        StaffMember.FirstName = txtFirstName.Text;
        // store the name in the session object
        Session["StaffMember"] = StaffMember;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff StaffMember = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaffId.Text);
        Found = StaffMember.Find(StaffId);
        if (Found == true)
        {
            txtFirstName.Text = StaffMember.FirstName;
            txtLastName.Text = StaffMember.LastName;
            txtEmailAddress.Text = StaffMember.EmailAddress;
            txtHomeAddress.Text = StaffMember.HomeAddress;
            txtStartDate.Text = StaffMember.StartDate.ToString();
        }
    }
}