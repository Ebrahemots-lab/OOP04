using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class Circle : ICircle
    {
        public int Area { get ; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Iam a Circle with Area: {Area}");
        }
    }
}
