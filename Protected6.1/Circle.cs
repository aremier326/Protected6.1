using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected6._1
{
    class Circle : Figure
    {
        public Circle() {}
        public Circle(double radius) : base(radius, 0) {}

        public override void CalculatePerimeter()
        {
            Console.WriteLine($"Here is perimeter of circle: {2 * Math.PI * xLength:f3}");
        }

        public override void CalculateSquare()
        {
            Console.WriteLine($"Here is square of circle: {Math.PI * Math.Pow(xLength, 2):f3}");
        }
    }
}
