using System;

namespace Lesson3_Ex1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter size of matrix: ");
            string strsize = Console.ReadLine();
            bool isInteger = int.TryParse(strsize, out int size);
            while (isInteger == false || size < 1)
            {
                Console.WriteLine("You enter incorrect value");
                Console.WriteLine("Please enter integer number >= 1");
                strsize = Console.ReadLine();
                isInteger = int.TryParse(strsize, out size);
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
