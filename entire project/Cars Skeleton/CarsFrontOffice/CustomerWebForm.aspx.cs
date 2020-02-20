using CarsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = clsCustomer();
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        Response.Write(AnCustomer.customerID);
    }

    protected void btnOk_CLICK(object sender, EventArgs e)
    {

    }
}