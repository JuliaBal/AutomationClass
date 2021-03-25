using System;

namespace Lesson1_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 2.");
            Console.WriteLine("Enter length");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height");
            int height = Convert.ToInt32(Console.ReadLine());

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
