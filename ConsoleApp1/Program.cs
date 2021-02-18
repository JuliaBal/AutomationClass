using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exersise 1
            Console.WriteLine("Enter x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter z");
            int z = Convert.ToInt32(Console.ReadLine());

            var fexpression = (int)((x + y) * (Math.Pow(z, 2) + 1));
            Console.WriteLine("First expression: " + fexpression);

            var sexpression = ((x % z) - 1) * (Math.Sqrt(y));
            Console.WriteLine("Second expression: " + (Math.Round(sexpression, 2)));

            var texpression = ((x + y) * (y + z)) / (Math.Pow(z, 3));
            Console.WriteLine("Third expression: " + (Math.Round(texpression, 2)));
            Console.ReadKey();

            //Exersise 2
            Console.WriteLine("Enter length");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height");
            int height = Convert.ToInt32(Console.ReadLine());

            var diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2) + Math.Pow(height, 2));
            Console.WriteLine("Parallelepiped diagonal length = " + (Math.Round(diagonal, 2)));
            Console.ReadKey();

            //Exersise 3
            Console.WriteLine("Enter string 1");
            var str1 = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter string 2");
            var str2 = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter string 3");
            var str3 = Console.ReadLine().ToUpper();

            if (str1.StartsWith(str2))
            {
                Console.WriteLine("First string starts from second string: " + str2);
            }
            else
            {
                Console.WriteLine("First string doesn't start from second string.");
            }

            if (str1.EndsWith(str3))
            {
                Console.WriteLine("First string ends with third string: " + str3);
            }
            else
            {
                Console.WriteLine("First string doesn't end with third string.");
            }
            Console.ReadKey();

            //Exersise 4
            Console.WriteLine("Enter string 1");
            String string1 = Console.ReadLine();
            Console.WriteLine("Enter string 2");
            String string2 = Console.ReadLine();
            Console.WriteLine("Enter symbol");
            char ch = Convert.ToChar(Console.ReadLine());
            String stringresult = string1 + string2;
            for (int k = (stringresult.Length - 1); k > 0; k --)
            {
                if (stringresult[k] == ch)
                {
                    Console.WriteLine("Index of symbol in string: " + k);
                }
                else
                {
                    Console.WriteLine("Symbol doesn't exist in string");
                }
                Console.ReadKey();
            }
        }
    }
}
