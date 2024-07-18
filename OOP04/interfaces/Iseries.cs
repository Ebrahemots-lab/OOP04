using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.interfaces
{
    internal interface Iseries
    {
        public int Current { get; set; }

        void GetNext();

        void Reset() 
        {
            Current = 0; 
        }
    }
}
