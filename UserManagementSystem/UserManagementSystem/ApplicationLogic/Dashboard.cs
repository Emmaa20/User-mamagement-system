using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementSystem.Database.Models;
using UserManagementSystem.Database.Repository;

namespace UserManagementSystem.ApplicationLogic
{
    internal class Dashboard
    {
        public static void AdminPanel(string email)
        {
            User user = UserRepository.GetUserByEmail(email);
            Console.WriteLine("Admin succesfully joined", user.GetInfo());

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Commands");

                Console.WriteLine("/show-user");
                Console.WriteLine("/log-out");
                Console.WriteLine();
                Console.WriteLine("Enter Command:");
                string command = Console.ReadLine();


                List<User> Users = UserRepository.GetAll();
                //if (command == "/show-user")
                //{
                //    foreach (User oneuser in users)
                //    {
                //        Console.Writeline(oneuser.id + " " + oneuser.name + " " + oneuser.surname + " " + oneuser.email);
                //    }
                //}
                //else if (command == "/log-out")
                //{
                //    Program.Main(new string[] { });
                //}
                //else
                //{
                //    Console.Writeline("command not found.....");
                //}
            }

        }

        public static void UserPanel(string email)
        {
            User user = UserRepository.GetUserByEmail(email);
            Console.WriteLine($"User successfully authenticated : {user.GetInfo()}");
            Console.WriteLine();

            Console.WriteLine("commands : / logout ");
            string command = Console.ReadLine();


        }
    }
}

