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
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection AllStaff = new clsStaffCollection();
        lstStaffList.DataSource = AllStaff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "FirstName";
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffId"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var storing the primary key value of the record to be edited
        Int32 StaffId;
        //if a record has been selected from the list
        if(lstStaffList.SelectedIndex != -1)
        {
            //get the primary key
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if(lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}