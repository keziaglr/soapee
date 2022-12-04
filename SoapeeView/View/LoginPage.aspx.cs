using SoapeeView.SoapeeWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoapeeView.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblError.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            SoapeeWS.WebService1 ws = new SoapeeWS.WebService1();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (ws.ValidateLogin(username, password))
            {
                User userNow = ws.GetUserByUsername(username);
                Session["user"] = userNow.UserId.ToString();

                if (userNow.Username.Equals("Admin"))
                {
                    Session["role"] = "admin";
                }
                else
                {
                    Session["role"] = "user";
                }
                Response.Redirect("~/View/Home.aspx");
            }
            else
            {
                lblError.Text = "Incorrect username or password!";
                return;
            }
        }
    }
}