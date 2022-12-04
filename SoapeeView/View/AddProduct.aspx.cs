using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoapeeView.View
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            SoapeeWS.WebService1 ws = new SoapeeWS.WebService1();
            string name = txtName.Text;
            string description = txtDesc.Text;
            string price = txtPrice.Text;

            if (!ws.ValidateName(name))
            {
                lblError.Text = "Product name must be filled!";
                return;
            }
            else if (!ws.ValidatePrice(price))
            {
                lblError.Text = "Product price must be numeric or filled!";
                return;
            }
            else if (!ws.ValidateDesc(description))
            {
                lblError.Text = "Product description must more than 20 characters!";
                return;
            }
            else
            {
                lblError.Text = "Successfully Added!";
                ws.InsertProduct(name, description, price);
                Response.Redirect("~/View/Home.aspx");
            }
        }

    }
}