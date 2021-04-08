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

        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string EmailAddress = txtEmailAddress.Text;
        string HomeAddress = txtHomeAddress.Text;
        string StartDate = txtStartDate.Text;
        string Error = "";

        Error = StaffMember.Valid(FirstName, LastName, EmailAddress, HomeAddress, StartDate);
        if(Error == "")
        {
            StaffMember.FirstName = FirstName;
            StaffMember.LastName = LastName;
            StaffMember.EmailAddress = EmailAddress;
            StaffMember.HomeAddress = HomeAddress;
            StaffMember.StartDate = Convert.ToDateTime(StartDate);
            clsStaffCollection StaffList = new clsStaffCollection();
            StaffList.ThisStaffMember = StaffMember;
            StaffList.Add();
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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