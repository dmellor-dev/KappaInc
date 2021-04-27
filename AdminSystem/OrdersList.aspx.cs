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
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrdersList.DataSource = Orders.OrdersList;
        lstOrdersList.DataValueField = "OrderId";
        lstOrdersList.DataTextField = "DeliveryAddress";
        lstOrdersList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderId;

        if (lstOrdersList.SelectedIndex != 1)
        {
            OrderId = Convert.ToInt32(lstOrdersList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("DeleteOrder.aspx");
        } else
        {
            lblError.Text = "Please Select an Order to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderId;

        if (lstOrdersList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrdersList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("AnOrder.aspx");
        } else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByProductCode(txtFilter.Text);
        lstOrdersList.DataSource = Orders.OrdersList;
        lstOrdersList.DataValueField = "OrderId";
        lstOrdersList.DataTextField = "ProductCode";

        lstOrdersList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByProductCode("");
        txtFilter.Text = "";
        lstOrdersList.DataSource = Orders.OrdersList;
        lstOrdersList.DataValueField = "OrderId";
        lstOrdersList.DataTextField = "ProductCode";

        lstOrdersList.DataBind();
    }
}