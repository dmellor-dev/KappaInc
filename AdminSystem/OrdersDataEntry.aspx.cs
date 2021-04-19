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
        int OrderId = Convert.ToInt32(txtOrderId.Text);
        int ItemId = Convert.ToInt32(txtItemId.Text);
        DateTime OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        string DeliveryAddress = txtDeliveryAddress.Text;
        Double UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
        int Quantity = Convert.ToInt32(txtQuantity.Text);
        string ProductCode = txtProductCode.Text;
        bool DispatchedStatus = chkDispatched.Checked;

        string Error = "";
        Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);

        if (Error == "")
        {
            AnOrder.OrderId = OrderId;
            AnOrder.ItemId = ItemId;
            AnOrder.OrderDate = OrderDate;
            AnOrder.DeliveryAddress = DeliveryAddress;
            AnOrder.UnitPrice = UnitPrice;
            AnOrder.Quantity = Quantity;
            AnOrder.ProductCode = ProductCode;
            AnOrder.DispatchedStatus = DispatchedStatus;

            clsOrderCollection OrdersList = new clsOrderCollection();
            OrdersList.ThisOrder = AnOrder;
            OrdersList.Add();

            Response.Redirect("OrdersList.aspx");
        } else
        {
            lblError.Text = Error;
        }
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");
    }
}