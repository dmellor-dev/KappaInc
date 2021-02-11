using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock someStock = new clsStock();
        //get the data from the session object
        someStock = (clsStock)Session["someStock"];
        //display the Item Name for this entry
        Response.Write(someStock.ItemName);
        Response.Write(someStock.ItemType);
        Response.Write(someStock.StockQuantity);
        Response.Write(someStock.Price);
        Response.Write(someStock.Available);
        Response.Write(someStock.Supplier);
        Response.Write(someStock.NextRestock);

    }
}