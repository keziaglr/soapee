using SoapeeWebService.Factory;
using SoapeeWebService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapeeWebService.Repository
{
    public class CartRepository
    {
        private static SoapeeDatabaseEntities1 db = new SoapeeDatabaseEntities1();

        public static List<Object> GetCart(int userId)
        {
            var carts = (from c in db.Carts
                        join p in db.Products on c.ProductId equals p.ProductId
                        select new
                        {
                            Name = p.Name,
                            Price = p.Price,
                            Description = p.Description,
                            ProductId = p.ProductId,
                            Amount = c.Quantity
                        }).ToList<Object>();
            return carts;
        }

        public static List<Cart> GetAllCart()
        {
            return db.Carts.ToList<Cart>();
        }

        public static List<Cart> GetAllCartByUserId(int userId)
        {
            return db.Carts.Where(x => x.UserId.Equals(userId)).ToList<Cart>();
        }

        public static Cart GetCartByUserIdandProductId(int userId, int productId)
        {
            return db.Carts.Where(x => x.UserId.Equals(userId) && x.ProductId.Equals(productId)).FirstOrDefault();
        }

        public static bool InsertCart(int userId, int productId, int quantity)
        {
            Cart cart = CartFactory.CreateCart(userId, productId, quantity);
            if(cart != null)
            {
                db.Carts.Add(cart);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool RemoveCart(int userId, int productId)
        {
            Cart cart = GetCartByUserIdandProductId(userId, productId);
            if (cart != null)
            {
                db.Carts.Remove(cart);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool RemoveAllCart(int userId)
        {
            List<Cart> cartList = GetAllCartByUserId(userId);
            foreach(Cart cart in cartList)
            {
                if(cart != null)
                {
                    db.Carts.Remove(cart);
                    db.SaveChanges();
                    return true;
                }  
            }
            return false;
        }

        public static void UpdateCart(int userId, int productId, int quantity)
        {
            Cart cart = GetCartByUserIdandProductId(userId, productId);
            if(cart == null)
            {
                if(quantity > 0)
                {
                    InsertCart(userId, productId, quantity);
                }
            }
            else if(cart != null)
            {
                cart.Quantity += quantity;
                if(cart.Quantity <= 0)
                {
                    RemoveCart(userId, productId);
                }
            }

            db.SaveChanges();
        }
    }
}