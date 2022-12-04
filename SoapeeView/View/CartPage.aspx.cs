using SoapeeView.SoapeeWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoapeeView.View
{
    public partial class CartPage : System.Web.UI.Page
    {
        private SoapeeWS.WebService1 ws = new SoapeeWS.WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["user"]);
            if (Session["user"] != null)
            {
                if (ws.GetAllCartByUserId(userId) == null)
                {
                    btnCheckout.Visible = false;
                }
                else
                {
                    Show_Data();
                }      
            }
            else
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
        }

        protected void Show_Data()
        {
            Int32.TryParse(Session["user"].ToString(), out int userId);

            var cartData = ws.GetAllCart();
            var productData = ws.GetAllProduct();
            var cartList = (from a in cartData
                            join b in productData on a.ProductId equals b.ProductId
                            where a.UserId.Equals(userId)
                            select new
                            {
                                Name = b.Name,
                                Price = b.Price,
                                Description = b.Description,
                                ProductId = a.ProductId,
                                Quantity = a.Quantity
                            }).ToList();
            for (int i = 0; i < cartList.Count; i++)
            {
                if (cartList.Count > 0)
                {
                    rptCart.DataSource = cartList;
                    rptCart.DataBind();
                }
            }
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["user"]);
            DateTime currentDate = DateTime.Now;
            ws.InsertTransaction(userId, currentDate);

            Transaction transaction = ws.GetTransactionByUserIdandDate(userId, currentDate);
            int transactionId = transaction.TransactionId;
            List<Cart> cartList = ws.GetAllCartByUserId(userId).ToList();

            foreach (Cart cart in cartList)
            {
                ws.InsertTransactionDetail(transactionId, cart.ProductId, cart.Quantity);
            }
            ws.RemoveAllCart(userId);
            Show_Data();
            Response.Redirect("~/View/CartPage.aspx");
        }

        protected void minusBtn_Click(object sender, EventArgs e)
        {
            int productId = Int32.Parse((sender as Button).CommandArgument);
            int userId = Convert.ToInt32(Session["user"]);
            ws.UpdateCart(userId, productId, -1);
            Show_Data();
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            int productId = Int32.Parse((sender as Button).CommandArgument);
            int userId = Convert.ToInt32(Session["user"]);
            ws.UpdateCart(userId, productId, 1);
            Show_Data();
        }

        protected void rptCart_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            int productId = Int32.Parse((sender as Button).CommandArgument);
            int userId = Convert.ToInt32(Session["user"]);
            ws.RemoveCart(userId, productId);
            Show_Data();
            Response.Redirect("~/View/CartPage.aspx");
        }
    }
}