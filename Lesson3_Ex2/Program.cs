using System;

namespace Lesson3_Ex2
{
    abstract class Figure
    {
        public abstract double AreaCalculator();
        public abstract double PerimeterCalculator();
    }

    class Circle : Figure
    {
        private int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override double AreaCalculator()
        {
            double circleArea = Math.PI * Math.Pow(radius, 2);
            return circleArea;
        }
        public override double PerimeterCalculator()
        {
            double circlePerimeter = 2 * Math.PI * radius;
            return circlePerimeter;
        }
    }
    class Rectangle : Figure
    {
        private int side1, side2;
        public Rectangle(int side1, int side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public override double AreaCalculator()
        {
            double rectangleArea = side1 * side2;
            return rectangleArea;
        }

        public override double PerimeterCalculator()
        {
            double rectanglePerimeter = (side1 + side2) * 2;
            return rectanglePerimeter;
        }
    }
    public class CustomConvert
    {
        public static int ConvertToIntegerFromString(string string_string)
        {
            bool isInteger = int.TryParse(string_string, out int integerValue);
            while (isInteger == false || integerValue < 1)
            {
                Console.WriteLine("You enter incorrect value");
                Console.WriteLine("Please enter integer number >= 1");
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

            Console.WriteLine("Please enter first side of Rectangle");
            string stringRectangleSide1 = Console.ReadLine();
            int rectangleSide1 = CustomConvert.ConvertToIntegerFromString(stringRectangleSide1);
            Console.WriteLine("Please enter second side of Rectangle");
            string stringRectangleSide2 = Console.ReadLine();
            int rectangleSide2 = CustomConvert.ConvertToIntegerFromString(stringRectangleSide2);
            Console.WriteLine("Please enter radius of Circle");
            string stringRadius = Console.ReadLine();
            int radius = CustomConvert.ConvertToIntegerFromString(stringRadius);
            
            Figure rectangle = new Rectangle(rectangleSide1, rectangleSide2);
            double rectangleArea = rectangle.AreaCalculator();
            double rectanglePerimener = rectangle.PerimeterCalculator();
            Console.WriteLine("Area of Rectangle is: " + rectangleArea);
            Console.WriteLine("Perimeter of Rectangle is: " + rectanglePerimener);

            Figure circle = new Circle(radius);
            double circleArea = circle.AreaCalculator();
            double circleRerimeter = circle.PerimeterCalculator();
            Console.WriteLine("Area of Circle is: " + circleArea);
            Console.WriteLine("Perimeter of Circle is: " + circleRerimeter);

            Console.ReadLine();
        }
    }
}