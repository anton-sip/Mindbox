using System;
using Mindbox.Interfaces;

namespace Mindbox.Geometry.Figure
{
    public class Triangle : ITriangle
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }
        public double Perimetr { get; init; }
        public double Square
        {
            get
            {
                return Math.Sqrt(
                    Perimetr / 2 * (Perimetr / 2 - SideA) * (Perimetr / 2 - SideB) * (Perimetr / 2 - SideC));
            }
        }

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="sideA">Сторона А</param>
        /// <param name="sideB">Сторона Б</param>
        /// <param name="sideC">Сторона С</param>
        /// <param name="epsillon">Точность вычислений</param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double sideA, double sideB, double sideC, double epsillon = Constants.Epsillon)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Perimetr = SideA + SideB + SideC;
            
            if (sideA <= 0)
            {
                throw new ArgumentException("Сторона должна быть больше нуля", nameof(sideA));
            }
            if (sideB <= 0)
            {
                throw new ArgumentException("Сторона должна быть больше нуля", nameof(sideB));
            }
            if (sideC <= 0)
            {
                throw new ArgumentException("Сторона должна быть больше нуля", nameof(sideC));
            }
            
            double maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
            if ((Perimetr - maxSide) - maxSide < epsillon)
            {
                throw new ArgumentException(
                    "Длина наибольшей стороны должна быть меньше суммы длин двух других сторон");
            }
            
        }

        public bool IsRightTriangle(double epsillon = Constants.Epsillon)
        {
            return (Math.Abs(SideA - Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2))) <= epsillon ||
                    Math.Abs(SideB - Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2))) <= epsillon ||
                    Math.Abs(SideC - Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2))) <= epsillon);
        }
    }
}