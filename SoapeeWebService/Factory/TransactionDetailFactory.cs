using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoapeeWebService.Model;

namespace SoapeeWebService.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail CreateTransactionDetail(int transactionId, int productId, int quantity)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionId = transactionId;
            td.ProductId = productId;
            td.Quantity = quantity;

            return td;
        }
    }
}