using System;
using Convert = Lesson1_Ex1.Convert;

namespace Lesson2_Calculator
{
    class Calculator
    {
        public static double GetOperationResult(int num1, int num2)
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
        public static void Main()
        {
            Console.WriteLine("Welcome to Calculator!");
            // Enter number1
            Console.WriteLine("Type first number and press Enter");
            string number1 = Console.ReadLine();
            int firstnumber = Convert.ConvertToIntegerFromString(number1);

            // Enter number2
            Console.WriteLine("Type second number and press Enter");
            string number2 = Console.ReadLine();
            int secondnumber = Convert.ConvertToIntegerFromString(number2);

            // Enter math option
            Console.WriteLine("Enter math option. + , - , * , / , ^ ");

            //Result of calculating
            double result = Calculator.GetOperationResult(firstnumber, secondnumber);
            Console.WriteLine("You result:" + result);
        }
    }
}
