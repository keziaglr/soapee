using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoapeeWebService.Model;

namespace SoapeeWebService.Factory
{
    public class TransactionFactory
    {

        public static Transaction CreateTransaction(int userId, DateTime time)
        {
            Transaction transaction = new Transaction();
            transaction.UserId = userId;
            transaction.Date = time;

            return transaction;
        }
    }
}