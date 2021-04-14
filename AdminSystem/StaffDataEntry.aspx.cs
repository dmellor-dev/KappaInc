using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if(IsPostBack == false)
        {
            if(StaffId != -1)
            {
                DisplayStaffInfo();
            }
        }
    }

    private void DisplayStaffInfo()
    {
        clsStaffCollection StaffRegister = new clsStaffCollection();
        StaffRegister.ThisStaffMember.Find(StaffId);
        txtStaffId.Text = StaffRegister.ThisStaffMember.StaffId.ToString();
        txtFirstName.Text = StaffRegister.ThisStaffMember.FirstName;
        txtLastName.Text = StaffRegister.ThisStaffMember.LastName;
        txtEmailAddress.Text = StaffRegister.ThisStaffMember.EmailAddress;
        txtHomeAddress.Text = StaffRegister.ThisStaffMember.HomeAddress;
        txtStartDate.Text = StaffRegister.ThisStaffMember.StartDate.ToString();
        chkIsWorking.Checked = StaffRegister.ThisStaffMember.IsWorking;
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
            StaffMember.StaffId = StaffId;
            StaffMember.FirstName = FirstName;
            StaffMember.LastName = LastName;
            StaffMember.EmailAddress = EmailAddress;
            StaffMember.HomeAddress = HomeAddress;
            StaffMember.StartDate = Convert.ToDateTime(StartDate);
            StaffMember.IsWorking = chkIsWorking.Checked;
            clsStaffCollection StaffList = new clsStaffCollection();
            
            if(StaffId == -1)
            {
                StaffList.ThisStaffMember = StaffMember;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaffMember.Find(StaffId);
                StaffList.ThisStaffMember = StaffMember;
                StaffList.Update();
            }

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