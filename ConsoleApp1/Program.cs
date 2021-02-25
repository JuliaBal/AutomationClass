using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("Exercise 1. Press any key");
            Console.ReadKey();
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

            else if(z == 0)
            {
                Console.WriteLine("!!!z = 0!!! cannot be divided by 0.");
            }

            else
            {
                var fexpression = ((x + y) * (Math.Pow(z, 2) + 1));
                Console.WriteLine("First expression: " + fexpression);

                var sexpression = ((x % z) - 1) * (Math.Sqrt(y));
                Console.WriteLine("Second expression: " + (Math.Round(sexpression, 2)));

                var texpression = ((x + y) * (y + z)) / (Math.Pow(z, 3));
                Console.WriteLine("Third expression: " + (Math.Round(texpression, 2)));
                Console.ReadKey();
            }

            //Exercise 2
            Console.WriteLine("Exercise 2. Press any key");
            Console.ReadKey();
            Console.WriteLine("Enter length");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height");
            int height = Convert.ToInt32(Console.ReadLine());

            if(length < 0 || width < 0 || height < 0)
            {
                Console.WriteLine("Incorrect data");
            }

            else
            {
                var diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2) + Math.Pow(height, 2));
                Console.WriteLine("Parallelepiped diagonal length = " + (Math.Round(diagonal, 2)));
                Console.ReadKey();
            }

            //Exercise 3
            Console.WriteLine("Exercise 3. Press any key");
            Console.ReadKey();
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

            //Exercise 4
            Console.WriteLine("Exercise 4. Press any key");
            Console.ReadKey();
            Console.WriteLine("Enter string 1");
            String string1 = Console.ReadLine();
            Console.WriteLine("Enter string 2");
            String string2 = Console.ReadLine();
            Console.WriteLine("Enter symbol");
            char ch = Convert.ToChar(Console.ReadLine());
            String stringresult = string1 + string2;
            int index = (stringresult.Length - 1);
            while (index != 0)
            {
                if (stringresult[index] == ch)
                {
                    Console.WriteLine("Index of " + ch + " in " + stringresult + ":" + index);
                    break;
                }
                else
                    index--;
            }

            Console.ReadKey();
        }
    }
}
