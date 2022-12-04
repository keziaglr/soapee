using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoapeeView.View
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                btnLogin.Visible = true;
                btnRegister.Visible = true;
                btnHome.Visible = true;
                btnCart.Visible = false;
                btnTransaction.Visible = false;
                btnLogout.Visible = false;
            }
            else
            {
                if (Session["role"].ToString().Equals("admin"))
                {
                    btnCart.Visible = false;
                    btnTransaction.Visible = false;
                    btnLogin.Visible = false;
                    btnRegister.Visible = false;
                    btnHome.Visible = true;
                    btnLogout.Visible = true;
                }
                else
                {
                    btnLogin.Visible = false;
                    btnRegister.Visible = false;
                    btnHome.Visible = true;
                    btnCart.Visible = true;
                    btnLogout.Visible = true;
                }

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/RegisterPage.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Home.aspx");
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/CartPage.aspx");
        }

        protected void btnTransaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/TransactionPage.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/Home.aspx");
            }
            if (!IsPostBack)
            {
                Session.RemoveAll();
                Response.Redirect("~/View/Home.aspx");
            }
        }
    }
}