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
        //create a new instance of clsStock
        clsStock someStock = new clsStock();
        //capture the ItemName
        someStock.ItemName = txtItemName.Text;
        someStock.ItemType = txtItemType.Text;
        someStock.StockQuantity = Int32.Parse(txtStockQuantity.Text);
        someStock.Price = double.Parse(txtPrice.Text);
        someStock.Available = bool.Parse(txtAvailable.Text);
        someStock.Supplier = txtSupplier.Text;
        someStock.NextRestock = Convert.ToDateTime(txtNextRestock.Text);
        //store the name in the session object
        Session["someStock"] = someStock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }

    protected void chkActive_CheckedChanged(object sender, EventArgs e)
    {

    }
}