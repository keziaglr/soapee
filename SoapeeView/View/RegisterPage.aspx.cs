using SoapeeView.SoapeeWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoapeeView.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            SoapeeWS.WebService1 ws = new SoapeeWS.WebService1();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (!ws.ValidateRegisterUsername(username))
            {
                lblError.Text = "Username must be filled or already exists!";
                return;
            }
            else if (!ws.ValidateRegisterPassword(password))
            {
                lblError.Text = "Password must be filled";
                return;
            }
            else
            {
                ws.InsertUser(username, password);
                Response.Redirect("~/View/LoginPage.aspx");
            }
        }
    }
}