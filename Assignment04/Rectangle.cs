using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class Rectangle : IRectangle
    {
        public int Area { get ; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Iam Rectangle With Area: {Area}");
        }
    }
}
