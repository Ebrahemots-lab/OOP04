using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.interfaces
{
    internal interface Ishape
    {
        //Signature Property
        public string? Shape { get; set; } 

        //Signature Method
        void CalculateShape(int x, int y);

        //Default Implemented Method
        void Print() 
        {
            Console.WriteLine($"Hello Iam Shape");
        }
    }
}
