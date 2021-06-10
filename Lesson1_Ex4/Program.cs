using System;

namespace Lesson1_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 4.");
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
