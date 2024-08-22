using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInterface
{
    internal interface IShape
    {
       void CalculateArea();
        void DefaultSquare(int side)
        {
            Console.WriteLine("Area of Square:"+Math.Pow(side, 2));
        }
    }
}
