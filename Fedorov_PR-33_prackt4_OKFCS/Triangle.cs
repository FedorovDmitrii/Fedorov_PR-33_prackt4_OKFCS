using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fedorov_PR_33_prackt4_OKFCS
{
    public class Triangle : Shape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public Triangle (double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными.");
            }
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideC + sideB <= sideA)
                throw new ArgumentException("Некорректные стороны треугольника.");
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

         public override double Area ()
        {
            double p = Perimeter( ) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public override double Perimeter ()
        {
            return SideC + SideB + SideA;
        }
        public override string ToString ()
        {
            return $"Треушольник: {SideA}, {SideB}, {SideC}";
        }
    }
}
