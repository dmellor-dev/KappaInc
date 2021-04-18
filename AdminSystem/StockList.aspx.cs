using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Text = "";
        //if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        //create an instance of the Item Collection
        clsItemCollection AllItems = new clsItemCollection();
        //set the data source to the list of items in the collection
        lstStockList.DataSource = AllItems.ItemList;
        //set the name of the primary key
        lstStockList.DataValueField = "ItemID";
        //set the data field to display
        lstStockList.DataTextField = "ItemName";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 into the session object to indicate that this is a new record
        Session["ItemID"] = -1;
        //Redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key of the record to be editied
        Int32 ItemID;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ItemID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ItemID"] = ItemID;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record from the list to Edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ItemID;
        if (lstStockList.SelectedIndex != -1)
        {
            ItemID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["ItemID"] = ItemID;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record from the list to Delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsItemCollection Items = new clsItemCollection();
        Items.ReportByItemType(txtFilter.Text);
        lstStockList.DataSource = Items.ItemList;
        lstStockList.DataValueField = "ItemID";
        lstStockList.DataTextField = "ItemName";
        lstStockList.DataBind();
        
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsItemCollection Items = new clsItemCollection();
        Items.ReportByItemType("");
        txtFilter.Text = "";
        lstStockList.DataSource = Items.ItemList;
        lstStockList.DataValueField = "ItemID";
        lstStockList.DataTextField = "ItemName";
        lstStockList.DataBind();
    }
}