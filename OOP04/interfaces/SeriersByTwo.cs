using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.interfaces
{
    internal class SeriersByTwo : Iseries
    {
        public int Current { get ; set ; }

        public void GetNext() => Current += 2;

    }
}
