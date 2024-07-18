using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Iclonable
{
    internal class Charcter : ICloneable , IComparable
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Health { get; set; }


        public Charcter(Charcter charcter)
        {
           Id = charcter.Id;
           Name = charcter.Name;
           Health = charcter.Health;
        }

        public Charcter()
        {
            
        }

        public object Clone()
        {
            //Return an object
            //Create object from the caller then return it 
            return new Charcter() 
            {
                Id = Id,
                Name = Name,
                Health = Health
            };
        }

        public override string ToString()
        {
            return $"Charcter id: {Id} :: Name: {Name} :: Health :{Health}";
        }

        public int CompareTo(object? obj)
        {
            Charcter z = (Charcter) obj;
            //100 - 200 - 600 - 400
            //200-100-600-400
            //200-600-100-400
            //200-600-400-100
            //600-200-400-100;
            //600-400-200-100
            if(Health > z.Health)
                return -1;
            else if (Health < z.Health)
                return 1;
            else
                return 0;
        }
    }
}
