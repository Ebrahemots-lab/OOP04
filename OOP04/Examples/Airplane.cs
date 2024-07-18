using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Examples
{
    internal class Airplane : Vechile, IMovable, IFlyable
    {
        void IMovable.Backword()
        {
            Console.WriteLine("Iam On Ground Moving Backword");
        }

        void IFlyable.Backword()
        {
            Console.WriteLine("Iam On Air moving Backword");
        }

        void IMovable.Foraward()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Foraward()
        {
            throw new NotImplementedException();
        }

        void IMovable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMovable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
