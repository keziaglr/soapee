using SoapeeWebService.Handler;
using SoapeeWebService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapeeWebService.Controller
{
    public class CartController
    {
        public static List<Object> GetCart(int userId)
        {
            return CartHandler.GetCart(userId);
        }

        public static List<Cart> GetAllCart()
        {
            return CartHandler.GetAllCart();
        }

        public static List<Cart> GetAllCartByUserId(int userId)
        {
            return CartHandler.GetAllCartByUserId(userId);
        }

        public static Cart GetCartByUserIdandProductId(int userId, int productId)
        {
            return CartHandler.GetCartByUserIdandProductId(userId, productId);
        }

        public static bool InsertCart(int userId, int productId, int quantity)
        {
            return CartHandler.InsertCart(userId, productId, quantity);
        }

        public static bool RemoveCart(int userId, int productId)
        {
            return CartHandler.RemoveCart(userId, productId);
        }

        public static bool RemoveAllCart(int userId)
        {
            return CartHandler.RemoveAllCart(userId);
        }

        public static void UpdateCart(int userId, int productId, int quantity)
        {
            CartHandler.UpdateCart(userId, productId, quantity);
        }
    }
}