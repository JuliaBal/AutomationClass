using System;

namespace Lesson1_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1.");
            Console.WriteLine("Enter x");
            string string_x = Console.ReadLine();
            bool isInteger = int.TryParse(string_x, out int x);
            while (isInteger == false)
            {
                Console.WriteLine("You enter incorrect value");
                Console.WriteLine("Please enter integer number");
                string_x = Console.ReadLine();
                isInteger = int.TryParse(string_x, out x);
            }
            Console.WriteLine("Enter y");
            string string_y = Console.ReadLine();
            isInteger = int.TryParse(string_y, out int y);
            while (isInteger == false)
            {
                Console.WriteLine("You enter incorrect value");
                Console.WriteLine("Please enter integer number");
                string_y = Console.ReadLine();
                isInteger = int.TryParse(string_y, out y);
            }
            Console.WriteLine("Enter z");
            string string_z = Console.ReadLine();
            isInteger = int.TryParse(string_z, out int z);
            while (isInteger == false)
            {
                Console.WriteLine("You enter incorrect value");
                Console.WriteLine("Please enter integer number");
                string_z = Console.ReadLine();
                isInteger = int.TryParse(string_z, out z);
            }

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
