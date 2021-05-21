using System;

namespace Lesson1_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 3.");
            Console.WriteLine("Enter string 1");
            var str1 = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter string 2");
            var str2 = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter string 3");
            var str3 = Console.ReadLine().ToUpper();

            if (str1.StartsWith(str2))
            {
                Console.WriteLine("String " + str1 + " starts from " + str2 + ": TRUE");
            }
            else
            {
                Console.WriteLine("String " + str1 + " starts from " + str2 + ": FALSE");
            }
            if (str1.EndsWith(str3))
            {
                Console.WriteLine("String " + str1 + " ends from " + str3 + ": TRUE");
            }
            else
            {
                Console.WriteLine("String " + str1 + " ends from " + str3 + ": FALSE");
            }
            Console.ReadKey();
        }
    }
}
