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
}