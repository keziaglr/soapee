using SoapeeView.SoapeeWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoapeeView.View
{
    public partial class ProductPage : System.Web.UI.Page
    {
        SoapeeWS.WebService1 ws = new SoapeeWS.WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Show_Data();
            }
        }

        protected void Show_Data()
        {
            List<Product> products = ws.GetAllProduct().ToList<Product>();
            for (int i = 0; i < products.Count; i++)
            {
                rptProduct.DataSource = products;
                rptProduct.DataBind();
            }
        }

        protected void minusBtn_Click(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/Login.aspx");
            }
            int productId = Int32.Parse((sender as Button).CommandArgument);
            int userId = Convert.ToInt32(Session["user"]);
            ws.UpdateCart(userId, productId, -1);
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/Login.aspx");
            }
            int productId = Int32.Parse((sender as Button).CommandArgument);
            int userId = Convert.ToInt32(Session["user"]);
            ws.UpdateCart(userId, productId, 1);
        }

        protected void rptProduct_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void rptProduct_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType.Equals(ListItemType.AlternatingItem) || e.Item.ItemType.Equals(ListItemType.Item))
            {
                Control addCart = e.Item.FindControl("add_cart");
                if (Session["user"] == null || Session["role"].ToString().Equals("admin"))
                {
                    addCart.Visible = false;
                }

            }
        }
    }
}