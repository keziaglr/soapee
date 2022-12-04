using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoapeeWebService.Model;

namespace SoapeeWebService.Factory
{
    public class CartFactory
    {
        public static Cart CreateCart(int userId, int productId, int quantity)
        {
            Cart cart = new Cart();
            cart.UserId = userId;
            cart.ProductId = productId;
            cart.Quantity = quantity;

            return cart;
        }
    }
}