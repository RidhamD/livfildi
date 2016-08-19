using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaFigures
{
    public class CalculateArea
    {
        public static double Triangle(int sideLength, int height)
        {
            return 0.5f * sideLength * height;
        }

        public static double Triangle(int sideLengthA, int sideLengthB, double angle)
        {
            angle = (Math.PI * angle) / 180; // перевод из градусов в радианы
            return 0.5f * sideLengthA * sideLengthB * Math.Sin(angle);
        }

        public static double Quadrangle(int diagonalOne, int diagonaTwo, double angle)
        {
            angle = (Math.PI * angle) / 180; // перевод из градусов в радианы
            return (diagonalOne * diagonaTwo * Math.Sin(angle)) / 2;
        }
        public static double Quadrangle(int sideLengthA, int sideLengthB, int sideLengthC, int sideLengthD)
        {
            float p = (sideLengthA + sideLengthB + sideLengthC + sideLengthD) / 2;
            return Math.Sqrt((p - sideLengthA) * (p - sideLengthB) * (p - sideLengthC) * (p - sideLengthD));
        }

        public static int Square(int side)
        {
            return side * side;
        }

    }
}
