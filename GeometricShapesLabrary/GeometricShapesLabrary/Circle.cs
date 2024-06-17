using System;

namespace GeometricShapesLabrary
{
    // Класс для вычисления площади круга
    internal class Circle : IGeometricShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be positive");
            }
            else
            {
                Radius = radius;
            }    
        }

        public double GetArea()
        {
            return Math.PI* Math.Pow(Radius, 2);
        }
    }
}
