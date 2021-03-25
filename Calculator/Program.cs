using System;

namespace Calculator
{
    class Calculator
    {
        public static double ResultofOperation(int num1, int num2)
        {
            double result = double.NaN;
            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("You cannot divide to 0");
                    }
                    else result = num1 / num2;
                    break;
                case "^":
                    result = Math.Pow(num1, num2); ;
                    break;
                default:
                    Console.WriteLine("You type incorrect symbol");
                    break;
            }
            return result;
        }
    }

    class Program { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator!");
            // Enter number1
            Console.WriteLine("Type first number and press Enter");
            int number1 = Convert.ToInt32(Console.ReadLine());

            // Enter number2
            Console.WriteLine("Type second number and press Enter");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Enter math option
            Console.WriteLine("Enter math option. + , - , * , / , ^ ");

            //Result of calculating
            double result = Calculator.ResultofOperation(number1, number2);
            Console.WriteLine("You result:" + result);
        }
    }
}
