using SoapeeWebService.Factory;
using SoapeeWebService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapeeWebService.Repository
{
    public class TransactionDetailRepository
    {
        private static SoapeeDatabaseEntities1 db = new SoapeeDatabaseEntities1();

        public static List<TransactionDetail> GetAllTransactionDetail()
        {
            return db.TransactionDetails.ToList<TransactionDetail>();
        }

        public static TransactionDetail GetTransactionDetailById(int transactionId)
        {
            return db.TransactionDetails.Find(transactionId);
        }

        public static bool InsertTransactionDetail(int transactionId, int productId, int amount)
        {
            TransactionDetail td = TransactionDetailFactory.CreateTransactionDetail(transactionId, productId, amount);
            if (td != null)
            {
                db.TransactionDetails.Add(td);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}