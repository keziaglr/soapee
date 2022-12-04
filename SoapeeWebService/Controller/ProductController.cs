using SoapeeWebService.Handler;
using SoapeeWebService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapeeWebService.Controller
{
    public class ProductController
    {
        public static bool IsEmpty(string text)
        {
            return text.Trim().Equals("");
        }

        public static bool IsValidRange(int range, string text)
        {
            return (text.Length > range);
        }

        public static bool IsNumeric(string number)
        {
            return Int32.TryParse(number, out int res);
        }

        public static bool ValidateName(string name)
        {
            return !IsEmpty(name);
        }

        public static bool ValidateDesc(string description)
        {
            return IsValidRange(20, description);
        }

        public static bool ValidatePrice(string price)
        {
            return IsNumeric(price) && !IsEmpty(price);
        }

        public static bool ValidateAllInput(string name, string description, string price)
        {
            return ValidateName(name) && ValidatePrice(price) && ValidateDesc(description);
        }

        public static Product GetProductById(int productId)
        {
            return ProductHandler.GetProductById(productId);
        }

        public static List<Product> GetAllProduct()
        {
            return ProductHandler.GetAllProduct();
        }

        public static bool InsertProduct(string name, string description, string price)
        {
            if(ValidateAllInput(name, description, price))
            {
                return ProductHandler.InsertProduct(name, description, Int32.Parse(price));
            }
            return false;
        }

        public static bool RemoveProduct(int productId)
        {
            return ProductHandler.RemoveProduct(productId);
        }

        public static bool UpdateProduct(int productId, string name, string description, string price)
        {
            if (ValidateAllInput(name, description, price))
            {
                return ProductHandler.UpdateProduct(productId, name, description, Int32.Parse(price));
            }
            return false;
        }
    }
}