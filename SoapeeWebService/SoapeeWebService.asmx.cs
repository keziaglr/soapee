using SoapeeWebService.Controller;
using SoapeeWebService.Handler;
using SoapeeWebService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SoapeeWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<Object> GetCart(int userId)
        {
            return CartHandler.GetCart(userId);
        }

        [WebMethod]
        public List<Cart> GetAllCart()
        {
            return CartHandler.GetAllCart();
        }

        [WebMethod]
        public List<Cart> GetAllCartByUserId(int userId)
        {
            return CartHandler.GetAllCartByUserId(userId);
        }

        [WebMethod]
        public Cart GetCartByUserIdandProductId(int userId, int productId)
        {
            return CartHandler.GetCartByUserIdandProductId(userId, productId);
        }

        [WebMethod]
        public bool InsertCart(int userId, int productId, int quantity)
        {
            return CartHandler.InsertCart(userId, productId, quantity);
        }

        [WebMethod]
        public bool RemoveCart(int userId, int productId)
        {
            return CartHandler.RemoveCart(userId, productId);
        }

        [WebMethod]
        public bool RemoveAllCart(int userId)
        {
            return CartHandler.RemoveAllCart(userId);
        }

        [WebMethod]
        public void UpdateCart(int userId, int productId, int quantity)
        {
            CartHandler.UpdateCart(userId, productId, quantity);
        }

        [WebMethod]
        public bool ValidateName(string name)
        {
            return ProductController.ValidateName(name);
        }

        [WebMethod]
        public bool ValidateDesc(string description)
        {
            return ProductController.ValidateDesc(description);
        }

        [WebMethod]
        public bool ValidatePrice(string price)
        {
            return ProductController.ValidatePrice(price);
        }

        [WebMethod]
        public bool ValidateAllInput(string name, string description, string price)
        {
            return ProductController.ValidateAllInput(name, description, price);
        }

        [WebMethod]
        public Product GetProductById(int productId)
        {
            return ProductHandler.GetProductById(productId);
        }

        [WebMethod]
        public List<Product> GetAllProduct()
        {
            return ProductHandler.GetAllProduct();
        }

        [WebMethod]
        public bool InsertProduct(string name, string description, string price)
        {
            return ProductController.InsertProduct(name, description, price);
        }

        [WebMethod]
        public bool RemoveProduct(int productId)
        {
            return ProductHandler.RemoveProduct(productId);
        }

        [WebMethod]
        public bool UpdateProduct(int productId, string name, string description, string price)
        {
            return ProductController.UpdateProduct(productId, name, description, price);
        }

        [WebMethod]
        public bool ValidateRegisterUsername(string username)
        {
            return UserController.ValidateRegisterUsername(username);
        }

        [WebMethod]
        public bool ValidateRegisterPassword(string password)
        {
            return UserController.ValidateRegisterPassword(password);
        }

        [WebMethod]
        public bool ValidateRegister(string username, string password)
        {
            return UserController.ValidateRegister(username, password);
        }

        [WebMethod]
        public bool ValidateLogin(string username, string password)
        {
            return UserController.ValidateLogin(username, password);
        }

        [WebMethod]
        public User GetUserByUserId(int userId)
        {
            return UserHandler.GetUserByUserId(userId);
        }

        [WebMethod]
        public User GetUserByUsername(string username)
        {
            return UserHandler.GetUserByUsername(username);
        }

        [WebMethod]
        public bool InsertUser(string username, string password)
        {
            return UserController.InsertUser(username, password);
        }

        [WebMethod]
        public bool RemoveUser(int userId)
        {
            return UserHandler.RemoveUser(userId);
        }

        [WebMethod]
        public bool UpdateUser(int userId, string username, string password)
        {
            return UserController.UpdateUser(userId, username, password);
        }

        [WebMethod]
        public List<Transaction> GetAllTransaction()
        {
            return TransactionHandler.GetAllTransaction();
        }

        [WebMethod]
        public Transaction GetTransactionById(int transactionId)
        {
            return TransactionHandler.GetTransactionById(transactionId);
        }

        [WebMethod]
        public Transaction GetTransactionByUserIdandDate(int userId, DateTime date)
        {
            return TransactionHandler.GetTransactionByUserIdandDate(userId, date);
        }

        [WebMethod]
        public bool InsertTransaction(int userId, DateTime date)
        {
            return TransactionHandler.InsertTransaction(userId, date);
        }

        [WebMethod]
        public List<TransactionDetail> GetAllTransactionDetail()
        {
            return TransactionDetailHandler.GetAllTransactionDetail();
        }

        [WebMethod]
        public TransactionDetail GetTransactionDetailById(int transactionId)
        {
            return TransactionDetailHandler.GetTransactionDetailById(transactionId);
        }

        [WebMethod]
        public void InsertTransactionDetail(int transactionId, int productId, int amount)
        {
            TransactionDetailHandler.InsertTransactionDetail(transactionId, productId, amount);
        }

    }
}
