using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoapeeView.View
{
    public partial class TransactionPage : System.Web.UI.Page
    {
        private SoapeeWS.WebService1 ws = new SoapeeWS.WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
            TransactionReport tr = new TransactionReport();
            CrystalReportViewer1.ReportSource = tr;

            SoapeeDataSet dataset = GetData();
            tr.SetDataSource(dataset);
        }

        protected SoapeeDataSet GetData()
        {
            int userId = Convert.ToInt32(Session["user"]);
            SoapeeDataSet ds = new SoapeeDataSet();
            var transaction = ds.Transaction;

            var products = ws.GetAllProduct();
            var transactions = ws.GetAllTransaction();
            var transactionDetails = ws.GetAllTransactionDetail();

            var dataTransaction = (from t in transactions
                                   join td in transactionDetails on t.TransactionId equals td.TransactionId
                                   join p in products on td.ProductId equals p.ProductId
                                   where t.UserId == userId
                                   select new
                                   {
                                       Name = p.Name,
                                       Price = p.Price,
                                       Quantity = td.Quantity
                                   }).ToList();

            foreach (var x in dataTransaction)
            {
                var row = transaction.NewRow();
                row["Name"] = x.Name;
                row["Price"] = x.Price;
                row["Quantity"] = x.Quantity;
                transaction.Rows.Add(row);
            }
            return ds;
        }
    }
}