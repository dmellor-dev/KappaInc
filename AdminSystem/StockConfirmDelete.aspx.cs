using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 ItemID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemID = Convert.ToInt32(Session["ItemID"]);
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }

    protected void btnYes_Click1(object sender, EventArgs e)
    {
        //create a new instance of the item list
        clsItemCollection ItemList = new clsItemCollection();
        //find the record to delete
        ItemList.ThisItem.Find(ItemID);
        //delete the record
        ItemList.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }
}