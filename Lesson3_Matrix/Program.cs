using System;
using Convert = Lesson1_Ex1.Convert;

namespace Lesson3_Matrix
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter size of matrix: ");
            string strsize = Console.ReadLine();
            int size = Convert.ConvertToIntegerFromString(strsize);
            while (size < 1)
            {
                Console.WriteLine("Please enter integer number >= 1");
                strsize = Console.ReadLine();
                size = Convert.ConvertToIntegerFromString(strsize);
            }
            int[,] array = new int[size, size];
            Random random = new Random();
            int sum = 0;
            int i, j;
            Console.WriteLine("Your matrix: ");
            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    array[i, j] = random.Next(0, 9);
                    Console.Write(array[i, j] + " ");
                    if (i == j)
                    {
                        sum += array[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix trace is: " + sum);
            Console.ReadLine();
        }
    }
}
