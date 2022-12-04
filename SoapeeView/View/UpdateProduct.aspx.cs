using System;
using SoapeeView.SoapeeWS;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoapeeView.View
{
    public partial class UpdateProduct : System.Web.UI.Page
    {
        private SoapeeWS.WebService1 ws = new SoapeeWS.WebService1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int productId = Int32.Parse(Request.QueryString["id"]);
                Product product = ws.GetProductById(productId);
                txtName.Text = product.Name;
                txtDesc.Text = product.Description;
                txtPrice.Text = product.Price.ToString();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int productId = Int32.Parse(Request.QueryString["id"]);
            Product product = ws.GetProductById(productId);
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
                ws.UpdateProduct(productId, name, description, price);
                Response.Redirect("~/View/Home.aspx");
            }
        }

    }
}