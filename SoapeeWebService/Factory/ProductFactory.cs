using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoapeeWebService.Model;

namespace SoapeeWebService.Factory
{
    public class ProductFactory
    {
        public static Product CreateProduct(string name, string description, int price)
        {
            Product product = new Product();
            product.Name = name;
            product.Description = description;
            product.Price = price;

            return product;
        }
    }
}