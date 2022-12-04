using SoapeeWebService.Factory;
using SoapeeWebService.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SoapeeWebService.Repository
{
    public class TransactionRepository
    {
        private static SoapeeDatabaseEntities1 db = new SoapeeDatabaseEntities1();

        public static List<Transaction> GetAllTransaction()
        {
            return db.Transactions.ToList<Transaction>();
        }

        public static Transaction GetTransactionById(int transactionId)
        {
            return db.Transactions.Find(transactionId);
        }

        public static Transaction GetTransactionByUserIdandDate(int userId, DateTime date)
        {
            var transactions = GetAllTransaction();
            foreach(var transaction in transactions)
            {
                var dt1 = Convert.ToDateTime(transaction.Date);
                var dts1 = dt1.ToString("g");
                var dt2 = Convert.ToDateTime(date);
                var dts2 = dt2.ToString("g");
                if (dts1.Equals(dts2))
                {
                    return (Transaction)transaction;
                }
            }
            return null;
        }

        public static bool InsertTransaction(int userId, DateTime date)
        {
            Transaction transaction = TransactionFactory.CreateTransaction(userId, date);
            if (transaction != null)
            {
                db.Transactions.Add(transaction);
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }
}