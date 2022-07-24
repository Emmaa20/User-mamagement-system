using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementSystem.Database.Repository;

namespace UserManagementSystem.Database.Models
{
    internal class User
    {
        public int ID { get; private set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }



        public User(string name, string surname, string email, string password)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            ID = UserRepository.IDCounter;
        }




        public User(string name, string surname, string email, string password, int id)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            ID = id;
        }

        internal static void Add(User user)
        {
            throw new NotImplementedException();
        }

        internal static void Remove(User user)
        {
            throw new NotImplementedException();
        }

        public virtual string GetInfo()
        {
            return Name + " " + Surname;
        }
    }

}

