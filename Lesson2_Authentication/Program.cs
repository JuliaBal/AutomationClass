using System;
using System.Collections.Generic;

namespace Lesson2_Authentication
{
    class Program
    {
        public static void Main()
        {
            Dictionary<string, string> users = new Dictionary<string, string>
            {
                { "user1", "password1" },
                { "user2", "password2" },
                { "user3", "password3" }
            };
            Console.WriteLine("Please enter your login");
            string login = Console.ReadLine();

            if (users.ContainsKey(login))
            {
                string password = users.GetValueOrDefault(login);
                for (int i = 0; i < 3; i++)
                {
                    int attempt = 2 - i;
                    Console.WriteLine("Please enter your password");
                    string value = Console.ReadLine();
                    if (value == password)
                    {
                        Console.WriteLine("Welcome");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Please enter your password!");
                        Console.WriteLine("you have " + attempt + " attempts left");
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect login");
            }
        }
    }
}
