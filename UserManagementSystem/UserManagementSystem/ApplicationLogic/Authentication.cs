using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementSystem.ApplicationLogic.Validations;
using UserManagementSystem.Database.Repository;

namespace UserManagementSystem.ApplicationLogic
{
    internal class Authentication
    {
        public static void Register()
        {
            Console.WriteLine();
            Console.Write("name :");
            string name = Console.ReadLine();

            while (!UserValidation.IsNameValid(name))
            {
                Console.Write("write name again:");
                name = Console.ReadLine();
            }

            Console.Write("surname :");
            string surname = Console.ReadLine();

            while (!UserValidation.IsSurnameValid(surname))
            {
                Console.Write("write surname again:");
                surname = Console.ReadLine();
            }

            Console.Write("email:");
            string email = Console.ReadLine();

            while (!UserValidation.IsEmailValid(email))
            {
                Console.Write("write email again:");
                email = Console.ReadLine();
            }

            Console.Write("password :");
            string password = Console.ReadLine();

            Console.Write("Confirm Password : ");
            string confirmPassword = Console.ReadLine();


            while (!(UserValidation.IsPasswordValid(password) && UserValidation.IsPaswordCorrect(password, confirmPassword)))
            {
                Console.Write("write password again:");
                password = Console.ReadLine();

                Console.Write("write confirm password again:");
                confirmPassword = Console.ReadLine();
            }

            UserRepository.Add(name, surname, email, password);
            Console.WriteLine("You succesfully registered you can login now with your account");
        }

        public static void Login()
        {
            Console.Write("Enter email:");
            string email = Console.ReadLine();

            Console.Write("Enter password:");
            string password = Console.ReadLine();


        }
    }
}

