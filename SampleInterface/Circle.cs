using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInterface
{
    internal class Circle : IShape
    {
        public int radius { get; set; }
        public void CalculateArea()
        {
            Console.WriteLine($"Area of Circle:{Math.PI*Math.Pow(radius, 2)}");
        }
    }
}
