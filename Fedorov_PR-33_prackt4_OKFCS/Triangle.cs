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
