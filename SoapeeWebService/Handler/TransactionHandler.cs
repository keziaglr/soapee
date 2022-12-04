using SoapeeWebService.Model;
using SoapeeWebService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapeeWebService.Handler
{
    public class TransactionHandler
    {
        public static List<Transaction> GetAllTransaction()
        {
            return TransactionRepository.GetAllTransaction();
        }
        public static Transaction GetTransactionById(int transactionId)
        {
            return TransactionRepository.GetTransactionById(transactionId);
        }

        public static Transaction GetTransactionByUserIdandDate(int userId, DateTime date)
        {
            return TransactionRepository.GetTransactionByUserIdandDate(userId, date);
        }

        public static bool InsertTransaction(int userId, DateTime date)
        {
            return TransactionRepository.InsertTransaction(userId, date);
        }
    }
}