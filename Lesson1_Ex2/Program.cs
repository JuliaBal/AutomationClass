using System;
using Convert = Lesson1_Ex1.Convert;

namespace Lesson1_Ex2
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Exercise 2.");
            Console.WriteLine("Enter length");
            string string_length = Console.ReadLine();
            int length = Convert.ConvertToIntegerFromString(string_length);
            Console.WriteLine("Enter width");
            string string_width = Console.ReadLine();
            int width = Convert.ConvertToIntegerFromString(string_width);
            Console.WriteLine("Enter height");
            string string_height = Console.ReadLine();
            int height = Convert.ConvertToIntegerFromString(string_height);

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
