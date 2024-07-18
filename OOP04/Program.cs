using OOP04.Examples;
using OOP04.Iclonable;
using OOP04.interfaces;
using System.IO.Pipes;
using System.Text;

namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interfaces
            //Interface => it's like a contract between Devlopers to use Same methods and attribute that Devloper who create interface want other to use
            //Simply it's like a steps devloper write then other devlopers use these steps to create stable application
            //nterface -> reference type
            //Inside Interfaces 
            //Segniture Property
            //Segniture of Method
            //Default implemented Method
            //Default acess Modifier for interface[internal]
            //Default acess modifier inside interface[public]


            //Ishape shape = new Ishape(); //Invalid 
            //we can't create object from Interface..only we create ref

            //Ishape shape; 
            //Clr will alocate 4 bytes for ref stored in stack and refere to null
            //shape ref can refere to any object from class that implement from this interface

            //shape.Shape = "circle" //Invalid becase shape refere to null

            //Ishape shape = new Circle();
            //shape.Print();//Valid
            //Circle class Implement from Ishape interface 

            //Circle circle = new Circle();
            //circle.Shape = "circle";
            //circle.CalculateShape(10, 20);

            //Ishape X = new Circle();
            //X.Shape = "Rectangular";
            //X.Print();

            #region Example 01
            //SeriersByTwo seriersByTwo = new SeriersByTwo();
            //PrintSeries(seriersByTwo);

            //SeriesByThree seriersByThree = new SeriesByThree();
            //PrintSeries(seriersByThree);
            #endregion

            #region Ex02
            //Circle c = new Circle();    
            //Rectangler r = new Rectangler();
            //Traingle t = new Traingle();

            //DrawShapes([c,r,t]);
            #endregion

            #region Ex03
            //Car car = new Car();
            //car.Speed = 100;
            //car.Backword();


            ////Impelment Interface Explicitly
            //IMovable move = new Airplane();
            //move.Backword();

            //IFlyable move02 = new Airplane();
            //move02.Backword();

            #endregion
            #endregion

            #region Shallow Copy - Deep Copy
            //Note: Shallow Copy and Deep Copy only work with reference type 
            #region Array of [Value Type]
            int[] arr01 = { 1, 2, 3 };
            int[] arr02 = new int[3];

            Console.WriteLine($"Hc of Arr01: {arr01.GetHashCode()}");
            Console.WriteLine($"Hc of Arr02: {arr02.GetHashCode()}");

            //We need to Copy data from Arr01 to arr02
            #region Shallow Copy 
            ////It's deal with Identity
            //arr02 = arr01;
            ////We copy the adress from arr01 and put it into arr02 
            ////now arr01 and arr02 refer to same object in the heap so any modification of one of thses arrayes will update in the other 
            //Console.WriteLine("After Shallow Copy");
            ////They both have the same adrees
            //Console.WriteLine($"Hc of Arr01: {arr01.GetHashCode()}");
            //Console.WriteLine($"Hc of Arr02: {arr02.GetHashCode()}");

            //arr01[0] = 100;

            //Console.WriteLine("After arr01[0] = 100");

            //Console.WriteLine(arr01[0]);
            //Console.WriteLine(arr01[0]);

            #endregion

            #region Deep Copy
            //it's create a new object in the heap with differenct Adress on the stack
            //arr02 = (int[])arr01.Clone(); // will Return an ojbect So we must Explicit convert it to the Datatype of the caller

            //Console.WriteLine("After Depp copy");

            //Console.WriteLine($"Hc of Arr01: {arr01.GetHashCode()}");
            //Console.WriteLine($"Hc of Arr02: {arr02.GetHashCode()}");
            ////After Deep copy we create a new object in the heap so it's create a new Identity and new data in the heap
            ////So any update in any of them will not update the other
            //arr01[0] = 100;

            //Console.WriteLine("After Assign");

            //Console.WriteLine(arr01[0]);
            //Console.WriteLine(arr02[0]);


            #endregion

            #endregion

            #region Array of [Reference Type]

            //string[] names01 = { "ots" };
            //string[] names02 = new string[1];

            //Console.WriteLine($"HC of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"HC of names02 = {names02.GetHashCode()}");
            #region Shallow Copy
            //Shalolow Copy we copy the adress from names01 and paste it into names02 in the heap
            //           names02 = names01;

            //           /*
            //            *                      [Stack]                               [Heap]
            //            *                      names01     -------- ->      [0x123]  -------> "ots"
            //            *                      names02    ----------->      [0x123] ------->"ots"
            //            *                      -------------Same Obj in the heap----------------------
            //            * 
            //            */

            //           Console.WriteLine("After Shallow Copy");

            //           Console.WriteLine($"HC of names01 = {names01.GetHashCode()}");
            //           Console.WriteLine($"HC of names02 = {names02.GetHashCode()}");

            //           names01[0] = "Ebrahem";


            //           /*
            //*                      [Stack]                               [Heap]
            //*                      names01     -------- ->      [0x123]  -------> "Ebrahem"
            //*                      names02    ----------->      [0x123] ------->"Ebrhem"
            //*                      -------------Same Obj in the heap----------------------
            //* 
            //*/


            //           Console.WriteLine(names02[0]);
            //           Console.WriteLine(names01[0]);



            #endregion

            #region Deep Copy

            //Console.WriteLine("Befor Deep Copy");
            //Console.WriteLine($"HC of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"HC of names02 = {names02.GetHashCode()}");

            ////Using CLone
            //names02 = (string[]) names01.Clone(); //return an object
            ////this will create a new object in the stack with different identity and same data as names01


            ///*
            // * 
            // *                  [Stack]                                [Heap]
            // *                  [names01]   ----------------> [0x1234] ---> "ots"
            // *                  [names02] ------------------> [0x5678] ---> null
            // *                  
            // *                  ----- After Cloning ------
            // *                  
            // *                  [names01] -------------> [0x1234] --> "ots"
            // *                  [names02] ------------->[ox1468] -> "ots"
            // *                  
            // *                  
            // *                  --After changing names[01] = "ebrahem"
            // *                  [names01] -------------> [0x1234] --> "ebrahem"
            // *                   [names02] ------------->[ox1468] -> "ots"
            // *                   
            // *                   becuse string is immutable so if we need to change it we create another object from it 
            // *                   so when we change names[01] to ebrahem we go directly to the adress on the stack and this addr refer to  another adrr in the heap
            // *                   then this addr refer to the actual value..
            // *                   so names02 -> nothing happpen on it because it's refer to a new add with new object in the heap
            // *                  
            // * 
            // * 
            // * 
            // */

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HC of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"HC of names02 = {names02.GetHashCode()}");


            //names01[0] = "Ebrahem";
            //Console.WriteLine("After Deep Copy");

            //Console.WriteLine(names01[0]);
            //Console.WriteLine(names02[0]);

            //because String is immutable 



            #endregion



            #endregion

            #region Array of [Reference Type] -> with String Builder

            StringBuilder[] names01= { new StringBuilder("ots")};

            StringBuilder[] names02 = new StringBuilder[1];

            //They have Differennt Hash code
            Console.WriteLine($"HC of names01 = {names01.GetHashCode()}");
            Console.WriteLine($"HC of names02 = {names02.GetHashCode()}");

            #region Shallow Copy
            //Wer will copy the adress in the stack

            names02 = names01;
            //they will have the same adress
            Console.WriteLine("After shallow copy");
            Console.WriteLine($"HC of names01 = {names01.GetHashCode()}");
            Console.WriteLine($"HC of names02 = {names02.GetHashCode()}");

            names01[0].Append("Ashraf");

            Console.WriteLine(names01[0]);
            Console.WriteLine(names02[0]);


            #endregion

            #region Deep Copy

            names02 = (StringBuilder[]) names01.Clone();

            Console.WriteLine("After Deep copy");
            Console.WriteLine($"HC of names01 = {names01.GetHashCode()}");
            Console.WriteLine($"HC of names02 = {names02.GetHashCode()}");

            names01[0].Append("aa");
            //it will print the same because names02 now has a new addr in the stack and same object in the heap that refere 
            //to the same data 
            //so stringbuilder mutable so if we append on it it didn't create a new object it's append to the me object
            Console.WriteLine(names01[0]);
            Console.WriteLine(names02[0]);


            #endregion

            #endregion

            #region Iclonable Interface
            //Charcter thanos = new Charcter() { Id = 10, Name = new StringBuilder("Thanos"), Health = 100 };
            //Charcter thor = new Charcter() { Id = 20, Name = new StringBuilder("Thor"), Health = 200 };

            Charcter thanos = new Charcter() { Id = 10, Name = "Thanos", Health = 100 };
            Charcter thor = new Charcter() { Id = 20, Name = "Thor", Health = 200 };

            Console.WriteLine($"Hc of thanos: {thanos.GetHashCode()}");
            Console.WriteLine($"Hc of thor: {thor.GetHashCode()}");
            #region Shallow Copy [String]
            //thor = thanos;

            //Console.WriteLine("After Shallow Copy");

            //Console.WriteLine($"Hc of thanos: {thanos.GetHashCode()}");
            //Console.WriteLine($"Hc of thor: {thor.GetHashCode()}");

            //thanos.Id = 200;
            //thanos.Name = "thanos2";
            //thanos.Health = 300;

            //Console.WriteLine(thanos);
            //Console.WriteLine(thor);




            #endregion

            #region Shallow Copy String Builder
            //thor = thanos;

            //Console.WriteLine("After Shallow Copy");

            //Console.WriteLine($"Hc of thanos: {thanos.GetHashCode()}");
            //Console.WriteLine($"Hc of thor: {thor.GetHashCode()}");

            //thor.Id = 300;
            //thor.Name.Append("Hello");

            //Console.WriteLine(thor);
            //Console.WriteLine(thor);




            #endregion

            #region Deep Copy [String]

            //thor = thanos.Clone(); //Invalid 

            //thor =  (Charcter) thanos.Clone();
            ////thanos and thor has two different identity but same data inside them
            ////Id = 10, Name = "Thanos", Health = 100

            //Console.WriteLine("After Deep Copy");

            //Console.WriteLine($"Hc of thanos: {thanos.GetHashCode()}");
            //Console.WriteLine($"Hc of thor: {thor.GetHashCode()}");

            //thanos.Name = "Thano02";
            //thanos.Id = 500;
            //Console.WriteLine(thanos);

            //Console.WriteLine(thor);

            //Different values 

            #endregion

            #region Deep Copy [String Builder]

            //thor = (Charcter) thanos.Clone();

            //thor.Id = 100;
            //thor.Name.Append("Hello");

            //Console.WriteLine(thanos);
            //Console.WriteLine(thor);

            //They both willl have the same name because we used string builder so they have both reference 
            //refer to same adress to the name


            //Another way to clone is Copy constructor

            thor = new Charcter(thanos);

            Console.WriteLine(thor);
            Console.WriteLine(thanos);





            #endregion




            #endregion


            #endregion



            Console.WriteLine("=========================");
            #region Icomparable
            Charcter[] chars =  
            {
                new Charcter(){Id = 1 , Name = "Thanos",Health = 100},
                new Charcter(){Id = 2 , Name = "Thor",Health = 200},
                new Charcter(){Id = 3 , Name = "Hulk",Health = 600},
                new Charcter(){Id = 4 , Name = "Captin America",Health = 400},
            };
            #endregion

            Array.Sort(chars);

            foreach(Charcter c in chars) 
            {
                Console.WriteLine(c);
            }

        }



        public static void DrawShapes(IDrawble[] shapes)
        {
            foreach (IDrawble shape in shapes)
            {
                shape.Draw();
            }
        }

        public static void PrintSeries(Iseries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    series.GetNext();

                    Console.Write(series.Current + " ");
                }
                series.Reset();
                Console.WriteLine();
            }
        }
    }
}
