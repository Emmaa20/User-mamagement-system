using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UserManagementSystem.Database.Models;
using UserManagementSystem.Database.Repository;

namespace UserManagementSystem.ApplicationLogic.Validations
{
    internal class UserValidation
    {
        public static bool IsNameValid(string name)
        {
            Regex regex = new Regex(@"^[A-Z]+[a-z]{2,30}");

            return regex.IsMatch(name);
        }

        public static bool IsSurnameValid(string surname)
        {
            Regex regex = new Regex(@"^[A-Z]+[a-z]{2,30}");

            return regex.IsMatch(surname);
        }

        public static bool IsEmailValid(string email)
        {
            Regex regex = new Regex(@" ^[a - z] +[\w.] + @code +[.] + edu +[.] + az");

            return regex.IsMatch(email);
        }

        public static bool IsPasswordValid(string password)
        {
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$");

            return regex.IsMatch(password);
        }

        public static bool IsPaswordCorrect(string password, string confirmPassword)
        {
            if (password == confirmPassword)
            {
                return true;
            }

            Console.WriteLine("The passwords you have entered do not match!");
            return false;
        }


        public static bool IsValidLogin(string email, string password)
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return true;
                }
            }

            return false;
        }

    }
}

