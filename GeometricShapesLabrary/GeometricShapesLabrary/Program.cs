using System;
using static System.Net.WebRequestMethods;

namespace GeometricShapesLabrary
{
    internal class Program
    {
        // Тестирование 
        static public bool CircleTest()
        {
            const double radius = 3;

            // https://calc.by/math-calculators/area-calculator.html#
            const double correctArea = 28.274333882308;
           
            double calculatedArea;

            try
            {
                Circle circle = new Circle(radius);
                calculatedArea = Math.Round(circle.GetArea(), 12);
            }
            catch
            {
                Console.WriteLine($"Unexpected exception");
                return false;
            }
            
            if (correctArea != calculatedArea)
            {
                Console.WriteLine($"Area calculated incorrectly for radius: {0}", radius);
                return false;
            }

            // Тест для исключения
            const double badRadius = -3;
      
            try
            {
                Circle badCircle = new Circle(badRadius);
            }
            catch
            {
                return true;
            }

            return false;
        }

        static public bool TriangleTest()
        {
            const double side_1 = 3;
            const double side_2 = 4;
            const double side_3 = 5;

            // https://calc.by/math-calculators/area-calculator.html#
            const double correctArea = 6;
            
            double calculatedArea;

            try
            {
                Triangle triangle = new Triangle(side_1, side_2, side_3);
                calculatedArea = triangle.GetArea();
            }
            catch
            {
                Console.WriteLine($"Unexpected exception");
                return false;
            }

            if (correctArea != calculatedArea)
            {
                Console.WriteLine($"Area calculated incorrectly for sides: {0}, {1}, {2}", side_1, side_2, side_3);
                return false;
            }

            // Тест для исключения
            const double badSide_1 = -3;
            const double badSide_2 = -4;
            const double badSide_3 = -5;
            bool isExceptionExist = false;

            try
            {
                Triangle triangle = new Triangle(badSide_1, badSide_2, badSide_3);
            }
            catch
            {
                // Ожидаемое исключение
                isExceptionExist = true;
            }

            if (!isExceptionExist)
            {
                return false;
            }

            const double badSide_1_1 = 2;
            const double badSide_2_2 = 4;
            const double badSide_3_3 = 6;

            try
            {
                Triangle triangle = new Triangle(badSide_1_1, badSide_2_2, badSide_3_3);
            }
            catch
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            // К сожалению, я не знакома с Unit-тест фреймворками
            // Но я понимаю принцип тестирования
            Console.WriteLine($"CircleTest is: {CircleTest()}");
            Console.WriteLine($"TriangleTest is: {TriangleTest()}");

            Console.WriteLine();

            // Вычисление площади фигуры без знания типа фигуры
            const double radius = 3;
            IGeometricShape shape_1 = new Circle(radius);

            const double side_1 = 3;
            const double side_2 = 4;
            const double side_3 = 5;
            IGeometricShape shape_2 = new Triangle(side_1, side_2, side_3);

            Console.WriteLine($"Circle area: {shape_1.GetArea()}");
            Console.WriteLine($"Triangle area: {shape_2.GetArea()}");
            
            Console.ReadKey();
        }
    }
}
