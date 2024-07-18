using OOP04.Iclonable;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP04.IComparer
{
    internal class CharById : System.Collections.IComparer
    {
        public int Compare(object? x, object? y)
        {
           Charcter charcterX = (Charcter)x;
           Charcter charcterY = (Charcter)y;


            //charcterX.id > charcterY.id => 1 
            //charcterX.id < charcterY.id => -1 
            //charcterX.id == charcterY.id => 0 
            // y > x => positive
            // x is null => postive

            //Y is null -> x > y -> 1 
            //Y and x is null => return 0 


            return charcterX?.Id.CompareTo(charcterY?.Id) ?? (charcterY is null ? 0 : -1);
        }
    }
}
