using SoapeeWebService.Model;
using SoapeeWebService.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapeeWebService.Controller
{
    public class TransactionController
    {
        public static List<Transaction> GetAllTransaction()
        {
            return TransactionHandler.GetAllTransaction();
        }
        public static Transaction GetTransactionById(int transactionId)
        {
            return TransactionHandler.GetTransactionById(transactionId);
        }

        public static Transaction GetTransactionByUserIdandDate(int userId, DateTime date)
        {
            return TransactionHandler.GetTransactionByUserIdandDate(userId, date);
        }

        public static bool InsertTransaction(int userId, DateTime date)
        {
            return TransactionHandler.InsertTransaction(userId, date);
        }
    }
}