using System;
using UserManagementSystem.ApplicationLogic;

namespace UserManagementSystem.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine();
            Console.WriteLine("/register");
            Console.WriteLine("/login");
            Console.WriteLine("/exit");
            while (true)
            {
                Console.WriteLine();
                Console.Write("Pleace enter command :");
                string command = Console.ReadLine();
                if (command == "/register")
                {
                    Authentication.Register();

                }
                else if (command == "/login")
                {

                    Authentication.Login();

                }
                else if (command == "/exit")
                {
                    Console.WriteLine("Thanks for using our application");
                    break;
                }
                else
                {
                    Console.WriteLine("Command not found ...");
                }
            }
        }
    }
}
