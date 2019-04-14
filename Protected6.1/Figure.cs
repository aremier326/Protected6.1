using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected6._1
{
    abstract class Figure
    {
        public Figure() { }

        public Figure(double xLength, double yLength)
        {
            this.xLength = xLength;
            this.yLength = yLength;
        }
        
        public double xLength { get; set; }
        public double yLength { get; set; }

        public abstract void CalculateSquare();
        public abstract void CalculatePerimeter();

    }
}
