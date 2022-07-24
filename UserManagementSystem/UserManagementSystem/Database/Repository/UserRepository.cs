using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementSystem.Database.Models;

namespace UserManagementSystem.Database.Repository
{
    internal class UserRepository
    {
        private static int _idcounter;

        public static int IDCounter
        {
            get
            {
                _idcounter++;
                return _idcounter;
            }

        }


        public static List<User> Users { get; set; } = new List<User>()
        {



        };

        public static User Add(string name, string surname, string email, string password)
        {
            User user = new User(name, surname, email, password, _idcounter);
            User.Add(user);
            return user;
        }

        public static User Add(string name, string surname, string email, string password, int id)
        {
            User user = new User(name, surname, email, password, id);
            User.Add(user);
            return user;
        }

        public static User Add(User user)
        {
            User.Add(user);
            return user;
        }
        public static User Add(Admin admin)
        {
            User.Add(admin);
            return admin;
        }

        public static void Delete(User user)
        {
            User.Remove(user);
        }


        public static List<User> GetAll()
        {
            return Users;
        }

        //public bool IsEmail(string email)
        //{
        //    foreach (User user in Users)
        //    {
        //        if (user.Email == email)
        //        {
        //            return true ;
        //        }
        //    }
        //}
        public static User GetUserByEmail(string email)
        {
            foreach (User user in Users)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }


        public static bool RemoveUserByEmail(string email)
        {
            foreach (User user in Users)
            {
                if (user.Email == email)
                {
                    User.Remove(user);
                    return true;
                }
            }
            return false;
        }
    }
}

