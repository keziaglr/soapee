using SoapeeWebService.Handler;
using SoapeeWebService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapeeWebService.Controller
{
    public class UserController
    {
        public static bool IsEmpty(string text)
        {
            return text.Trim().Equals("");
        }

        public static bool IsRegistered(string username)
        {
            if (GetUserByUsername(username) != null)
            {
                return true;
            }
            return false;
        }

        public static bool ValidateRegisterUsername(string username)
        {
            if(!IsEmpty(username) && !IsRegistered(username))
            {
                return true;
            }
            return false;
        }

        public static bool ValidateRegisterPassword(string password)
        {
            if (!IsEmpty(password))
            {
                return true;
            }
            return false;
        }

        public static bool ValidateRegister(string username, string password)
        {
            return ValidateRegisterUsername(username) && ValidateRegisterPassword(password);
        }

        public static bool ValidateLogin(string username, string password)
        {
            User user = GetUserByUsername(username);
            if (user != null && user.Password.Equals(password))
            {
                return true;
            }
            return false;
        }

        public static User GetUserByUserId(int userId)
        {
            return UserHandler.GetUserByUserId(userId);
        }

        public static User GetUserByUsername(string username)
        {
            return UserHandler.GetUserByUsername(username);
        }

        public static bool InsertUser(string username, string password)
        {
            if(ValidateRegister(username, password))
            {
                return UserHandler.InsertUser(username, password);
            }
            return false;
        }

        public static bool RemoveUser(int userId)
        {
            return UserHandler.RemoveUser(userId);
        }

        public static bool UpdateUser(int userId, string username, string password)
        {
            if (ValidateRegister(username, password))
            {
                return UserHandler.UpdateUser(userId, username, password);
            }
            return false;
        }
    }
}