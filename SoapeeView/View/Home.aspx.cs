using SoapeeView.SoapeeWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoapeeView.View
{
    public partial class Home : System.Web.UI.Page
    {
        private SoapeeWS.WebService1 ws = new SoapeeWS.WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Show_Data();
            }
        }

        protected void Show_Data()
        {
            List<Product> productList = ws.GetAllProduct().ToList<Product>();
            for (int i = 0; i < productList.Count; i++)
            {
                rptProduct.DataSource = productList;
                rptProduct.DataBind();
            }
        }

        protected void rptProduct_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void rptProduct_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType.Equals(ListItemType.AlternatingItem) || e.Item.ItemType.Equals(ListItemType.Item))
            {
                Control addCart = e.Item.FindControl("add_cart");
                Control adminView = e.Item.FindControl("admin_view");

                if (Session["user"] == null)
                {
                    addCart.Visible = false;
                    adminView.Visible = false;
                    btnInsert.Visible = false;
                }
                else if (Session["role"].ToString().Equals("admin"))
                {
                    addCart.Visible = false;
                    adminView.Visible = true;
                    btnInsert.Visible = true;
                }
                else if (Session["role"].ToString().Equals("user"))
                {
                    addCart.Visible = true;
                    adminView.Visible = false;
                    btnInsert.Visible = false;
                }
            }
        }

        protected void btnMinus_Click(object sender, EventArgs e)
        {
            int productId = Int32.Parse((sender as Button).CommandArgument);
            int userId = Convert.ToInt32(Session["user"]);
            ws.UpdateCart(userId, productId, -1);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int productId = Int32.Parse((sender as Button).CommandArgument);
            int userId = Convert.ToInt32(Session["user"]);
            ws.UpdateCart(userId, productId, 1);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int productId = Int32.Parse((sender as Button).CommandArgument);
            Response.Redirect("~/View/UpdateProduct.aspx?id=" + productId);
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            int productId = Int32.Parse((sender as Button).CommandArgument);
            SoapeeWS.WebService1 ws = new SoapeeWS.WebService1();
            ws.RemoveProduct(productId);
            Show_Data();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/AddProduct.aspx");
        }
    }
}