using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Examples
{
    internal class Car : Vechile, IMovable
    {
        public void Backword()
        {
            Console.WriteLine("Iam MOving backword");
        }

        public void Foraward()
        {
            throw new NotImplementedException();
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }
    }
}
