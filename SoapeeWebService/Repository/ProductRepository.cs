using SoapeeWebService.Factory;
using SoapeeWebService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapeeWebService.Repository
{
    public class ProductRepository
    {
        private static SoapeeDatabaseEntities1 db = new SoapeeDatabaseEntities1();

        public static Product GetProductById(int productId)
        {
            return db.Products.Find(productId);
        }

        public static List<Product> GetAllProduct()
        {
            return db.Products.ToList<Product>();
        }

        public static bool InsertProduct(string name, string description, int price)
        {
            Product product = ProductFactory.CreateProduct(name, description, price);
            if (product != null)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool RemoveProduct(int productId)
        {
            Product product = GetProductById(productId);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateProduct(int productId, string name, string description, int price)
        {
            Product product = GetProductById(productId);
            if (product != null)
            {
                product.Name = name;
                product.Description = description;
                product.Price = price;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}