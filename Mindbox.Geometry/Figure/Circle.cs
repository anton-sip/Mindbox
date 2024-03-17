using System;
using Mindbox.Interfaces;

namespace Mindbox.Geometry.Figure
{
    public class Circle : IFigure
    {
        private double Radius { get; init; }
        public double Square
        {
            get
            {
                return Math.Pow(Radius, 2) * Math.PI;
            }
        }
        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радуис</param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть больше нуля", nameof(radius));
            }

            Radius = radius;
        }


    }
}