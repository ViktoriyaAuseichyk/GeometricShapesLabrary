using System;

namespace GeometricShapesLabrary
{
    // Класс для вычисления площади треугольника

    internal class Triangle : IGeometricShape
    {
        public double Side_1 { get; set; }
        public double Side_2 { get; set; }
        public double Side_3 { get; set; }

        public Triangle(double side_1, double side_2, double side_3) 
        { 
            if (side_1 <= 0 || side_2 <= 0 || side_3 <= 0)
            {
                throw new ArgumentException("Radius must be positive");
            }
            else if (side_1 + side_2 <= side_3 || side_1 + side_3 <= side_2 || side_2 + side_3 <= side_1)
            {
                throw new ArgumentException("The given sides don't form a triangle");
            }
            else
            {
                Side_1 = side_1;
                Side_2 = side_2;
                Side_3 = side_3;
            }
        }

        public double GetArea()
        { 
            // Формула Герона 
            double p = (Side_1 + Side_2 + Side_3) / 2; 
            return Math.Sqrt(p * (p - Side_1) * (p - Side_2 * (p - Side_3))); 
        }

        // Проверка на то, является ли треугольник прямоугольным 
        public bool IsRightTrangle()
        {
            double[] sides = { Side_1, Side_2, Side_3 };
            Array.Sort(sides);

            if (Math.Pow(sides[0], 2) == (Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
