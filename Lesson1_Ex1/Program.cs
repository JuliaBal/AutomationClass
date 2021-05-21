using System;

namespace Lesson1_Ex1
{
    public class Convert
    {
        public static int ConvertToIntegerFromString(string string_string)
        {
            bool isInteger = int.TryParse(string_string, out int integerValue);
            while (isInteger == false)
            {
                Console.WriteLine("You enter incorrect value");
                Console.WriteLine("Please enter integer number");
                string_string = Console.ReadLine();
                isInteger = int.TryParse(string_string, out integerValue);
            }
            return integerValue;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Exercise 1.");
            Console.WriteLine("Enter x");
            string string_x = Console.ReadLine();
            int x = Convert.ConvertToIntegerFromString(string_x);
            Console.WriteLine("Enter y");
            string string_y = Console.ReadLine();
            int y = Convert.ConvertToIntegerFromString(string_y);
            Console.WriteLine("Enter z");
            string string_z = Console.ReadLine();
            int z = Convert.ConvertToIntegerFromString(string_z);
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
