using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.interfaces
{
    internal class Circle : Ishape, IDrawble //Implemeneted
    {
        #region Implemented Implecitly
        public string? Shape { get; set; }

        public void CalculateShape(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        public void Draw()
        {
            Console.WriteLine("Iam Circle");
        }
        #endregion
    }
}
