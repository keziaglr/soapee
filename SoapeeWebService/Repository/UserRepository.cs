using SoapeeWebService.Factory;
using SoapeeWebService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapeeWebService.Repository
{
    public class UserRepository
    {
        private static SoapeeDatabaseEntities1 db = new SoapeeDatabaseEntities1();

        public static User GetUserByUserId(int userId)
        {
            return db.Users.Find(userId);
        }

        public static User GetUserByUsername(string username)
        {
            return db.Users.Where(x => x.Username.Equals(username)).FirstOrDefault();
        }

        public static bool InsertUser(string username, string password)
        {
            User user = UserFactory.CreateUser(username, password);
            if (user != null)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool RemoveUser(int userId)
        {
            User user = GetUserByUserId(userId);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateUser(int userId, string username, string password)
        {
            User user = GetUserByUserId(userId);
            if (user != null)
            {
                user.Username = username;
                user.Password = password;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}