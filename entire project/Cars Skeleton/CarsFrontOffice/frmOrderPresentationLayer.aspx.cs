using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarsClasses;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //clsOrder AnOrder = new clsOrder();
        //AnOrder = (clsOrder)Session["AnAddress"];
        ////displays the order id 
        //Response.Write(AnOrder.OrderId);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder.OrderId = Int32.Parse(txtOrderId.Text);
        AnOrder.CustomerId = Int32.Parse(txtCustomerID.Text);
        AnOrder.StaffId = Int32.Parse(txtStaffID.Text);
        AnOrder.VinNumber = Int32.Parse(txtVinNumber.Text);
        AnOrder.Location = txtLocation.Text;
        AnOrder.Finance = (cbFinance.Checked);
        AnOrder.PaymentStatus = (cbPaymentStatus.Checked);
        AnOrder.Date = DateTime.Parse(txtDate.Text);
        AnOrder.Price = decimal.Parse(txtPrice.Text);


        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");

    }
}