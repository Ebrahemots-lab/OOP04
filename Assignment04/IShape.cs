using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal interface IShape
    {
        public int Area { get; set; }

        void DisplayShapeInfo();
    }
}
