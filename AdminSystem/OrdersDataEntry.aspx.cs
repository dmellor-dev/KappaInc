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

    protected void btnAccept_Click(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        Session["AnOrder"] = AnOrder;
        //Navigate to order viewer page
        Response.Redirect("OrdersViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();
        Int32 OrderId;
        Boolean Found = false;
        OrderId = Convert.ToInt32(txtOrderId.Text);
        Found = AnOrder.Find(OrderId);
        if (Found == true)
        {
            txtItemId.Text = Convert.ToString(AnOrder.ItemId);
            txtOrderDate.Text = Convert.ToString(AnOrder.OrderDate);
            txtDeliveryAddress.Text = AnOrder.DeliveryAddress;
            txtUnitPrice.Text = Convert.ToString(AnOrder.UnitPrice);
            txtQuantity.Text = Convert.ToString(AnOrder.Quantity);
            txtProductCode.Text = Convert.ToString(AnOrder.ProductCode);
            chkDispatched.Checked = Convert.ToBoolean(AnOrder.DispatchedStatus);
        } else
        {
            lblError.Text = "Order ID not recognised";
        }
    }
}