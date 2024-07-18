using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.interfaces
{
    internal class Rectangler : IDrawble
    {
        public void Draw()
        {
            Console.WriteLine("Iam Rectangler");
        }
    }
}
