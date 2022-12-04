using SoapeeWebService.Model;
using SoapeeWebService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapeeWebService.Handler
{
    public class ProductHandler
    {
        public static Product GetProductById(int productId)
        {
            return ProductRepository.GetProductById(productId);
        }

        public static List<Product> GetAllProduct()
        {
            return ProductRepository.GetAllProduct();
        }

        public static bool InsertProduct(string name, string description, int price)
        {
            return ProductRepository.InsertProduct(name, description, price);
        }

        public static bool RemoveProduct(int productId)
        {
            return ProductRepository.RemoveProduct(productId);
        }

        public static bool UpdateProduct(int productId, string name, string description, int price)
        {
            return ProductRepository.UpdateProduct(productId, name, description, price);
        }
    }
}