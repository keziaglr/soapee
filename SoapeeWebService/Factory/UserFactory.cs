using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoapeeWebService.Model;

namespace SoapeeWebService.Factory
{
    public class UserFactory
    {
        public static User CreateUser(string username, string password)
        {
            User user = new User();
            user.Username = username;
            user.Password = password;

            return user;
        }
    }
}