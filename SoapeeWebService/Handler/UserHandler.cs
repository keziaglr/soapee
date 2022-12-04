using SoapeeWebService.Model;
using SoapeeWebService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapeeWebService.Handler
{
    public class UserHandler
    {
        public static User GetUserByUserId(int userId)
        {
            return UserRepository.GetUserByUserId(userId);
        }

        public static User GetUserByUsername(string username)
        {
            return UserRepository.GetUserByUsername(username);
        }

        public static bool InsertUser(string username, string password)
        {
            return UserRepository.InsertUser(username, password);
        }

        public static bool RemoveUser(int userId)
        {
            return UserRepository.RemoveUser(userId);
        }

        public static bool UpdateUser(int userId, string username, string password)
        {
            return UserRepository.UpdateUser(userId, username, password);
        }
    }
}