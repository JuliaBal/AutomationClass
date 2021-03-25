using System;

namespace Lesson1_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1.");
            Console.WriteLine("Enter x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter z");
            int z = Convert.ToInt32(Console.ReadLine());

            if (y < 0)
            {
                Console.WriteLine("!!!y < 0!!! the square root of a negative number does not exist.");
            }

            else if (z == 0)
            {
                Console.WriteLine("!!!z = 0!!! cannot be divided by 0.");
            }

            else
            {
                var fexpression = ((x + y) * (Math.Pow(z, 2) + 1));
                Console.WriteLine("First expression: " + fexpression);

                var sexpression = ((x % z) - 1) * (Math.Sqrt(y));
                Console.WriteLine("Second expression: " + sexpression);

                var texpression = ((x + y) * (y + z)) / (Math.Pow(z, 3));
                Console.WriteLine("Third expression: " + texpression);
                Console.ReadKey();
            }
        }
    }
}
