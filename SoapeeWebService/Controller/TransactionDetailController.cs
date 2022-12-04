using SoapeeWebService.Handler;
using SoapeeWebService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapeeWebService.Controller
{
    public class TransactionDetailController
    {
        public static List<TransactionDetail> GetAllTransactionDetail()
        {
            return TransactionDetailHandler.GetAllTransactionDetail();
        }
        public static TransactionDetail GetTransactionDetailById(int transactionId)
        {
            return TransactionDetailHandler.GetTransactionDetailById(transactionId);
        }

        public static void InsertTransactionDetail(int transactionId, int productId, int amount)
        {
            TransactionDetailHandler.InsertTransactionDetail(transactionId, productId, amount);
        }
    }
}