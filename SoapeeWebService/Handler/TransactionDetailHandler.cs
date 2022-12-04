using SoapeeWebService.Model;
using SoapeeWebService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapeeWebService.Handler
{
    public class TransactionDetailHandler
    {
        public static List<TransactionDetail> GetAllTransactionDetail()
        {
            return TransactionDetailRepository.GetAllTransactionDetail();
        }
        public static TransactionDetail GetTransactionDetailById(int transactionId)
        {
            return TransactionDetailRepository.GetTransactionDetailById(transactionId);
        }

        public static void InsertTransactionDetail(int transactionId, int productId, int amount)
        {
            TransactionDetailRepository.InsertTransactionDetail(transactionId, productId, amount);
        }
    }
}