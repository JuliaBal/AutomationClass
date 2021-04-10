using System;

namespace Lesson1_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 2.");
            Console.WriteLine("Enter length");
            string string_length = Console.ReadLine();
            bool isInteger = int.TryParse(string_length, out int length);
            while (isInteger == false)
            {
                Console.WriteLine("You enter incorrect length");
                Console.WriteLine("Please enter integer number");
                string_length = Console.ReadLine();
                isInteger = int.TryParse(string_length, out length);
            }
            Console.WriteLine("Enter width");
            string string_width = Console.ReadLine();
            isInteger = int.TryParse(string_width, out int width);
            while (isInteger == false)
            {
                Console.WriteLine("You enter incorrect width");
                Console.WriteLine("Please enter integer number");
                string_width = Console.ReadLine();
                isInteger = int.TryParse(string_width, out width);
            }
            Console.WriteLine("Enter height");
            string string_height = Console.ReadLine();
            isInteger = int.TryParse(string_height, out int height);
            while (isInteger == false)
            {
                Console.WriteLine("You enter incorrect height");
                Console.WriteLine("Please enter integer number");
                string_height = Console.ReadLine();
                isInteger = int.TryParse(string_height, out height);
            }

            if (length < 0 || width < 0 || height < 0)
            {
                Console.WriteLine("Incorrect data");
            }

            else
            {
                var diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2) + Math.Pow(height, 2));
                Console.WriteLine("Parallelepiped diagonal length = " + diagonal);
                Console.ReadKey();
            }
        }
    }
}
