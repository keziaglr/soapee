using SoapeeWebService.Model;
using SoapeeWebService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapeeWebService.Handler
{
    public class CartHandler
    {
        public static List<Object> GetCart(int userId)
        {
            return CartRepository.GetCart(userId);
        }

        public static List<Cart> GetAllCart()
        {
            return CartRepository.GetAllCart();
        }

        public static List<Cart> GetAllCartByUserId(int userId)
        {
            return CartRepository.GetAllCartByUserId(userId);
        }

        public static Cart GetCartByUserIdandProductId(int userId, int productId)
        {
            return CartRepository.GetCartByUserIdandProductId(userId, productId);
        }

        public static bool InsertCart(int userId, int productId, int quantity)
        {
            return CartRepository.InsertCart(userId, productId, quantity);
        }

        public static bool RemoveCart(int userId, int productId)
        {
            return CartRepository.RemoveCart(userId, productId);
        }

        public static bool RemoveAllCart(int userId)
        {
            return CartRepository.RemoveAllCart(userId);
        }

        public static void UpdateCart(int userId, int productId, int quantity)
        {
            CartRepository.UpdateCart(userId, productId, quantity);
        }
    }
}