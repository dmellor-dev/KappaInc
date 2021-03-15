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
        //capture the inputs as strings
        String ItemName = txtItemName.Text;
        String ItemType = txtItemType.Text;
        String StockQuantity = txtStockQuantity.Text;
        String Price = txtPrice.Text;
        String Supplier = txtSupplier.Text;
        String NextRestock = txtNextRestock.Text;
        String Error = "";
        // validate the data
        Error = someStock.Valid(ItemName, ItemType, StockQuantity, Price, Supplier, NextRestock);
        if (Error == "")//If it was fine collect the data
        {
            someStock.ItemName = ItemName;
            someStock.ItemType = ItemType;
            someStock.StockQuantity = Int32.Parse(StockQuantity);
            someStock.Price = Double.Parse(Price);
            someStock.Supplier = Supplier;
            someStock.NextRestock = Convert.ToDateTime(NextRestock);
        }
        else
        {
            lblError.Text = Error;
        }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        try
        {


            //create an instance of the stock class
            clsStock someStock = new clsStock();
            //Variable to store the primary key
            Int32 ItemId;
            //variable to store the result of the find operation
            Boolean Found = false;
            //get the primary key entered by the user
            ItemId = Convert.ToInt32(txtItemID.Text);
            //find the record
            Found = someStock.Find(ItemId);
            //if found
            if (Found == true)
            {
                lblError.Text = "";
                txtItemName.Text = someStock.ItemName;
                txtItemType.Text = someStock.ItemType;
                txtStockQuantity.Text = someStock.StockQuantity.ToString();
                txtPrice.Text = someStock.Price.ToString();
                txtSupplier.Text = someStock.Supplier;
                txtNextRestock.Text = someStock.NextRestock.ToString();
            } else
            {
                lblError.Text = "Item ID not found";
            }
        }
        catch (Exception)
        {
            lblError.Text = "Item ID not valid";
            txtItemName.Text = "";
            txtItemType.Text = "";
            txtStockQuantity.Text = "";
            txtPrice.Text = "";
            txtSupplier.Text = "";
            txtNextRestock.Text = "";

        }
    }
}