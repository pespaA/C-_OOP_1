using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal struct Point
    {
        // Attributes
        public int X;
        public int Y;

        //--------------------------
        // Constructor: Is Special Function
        // 1- Named Always With The Same Name Of Class Or Struct
        // 2- Has No Return 
        // By Default At Struct , Compiler Will Alwayes Generate Paramterless Constructor
        public Point() // ctor+tap
        {
            X = 0;
            Y = 0;
        }
        public Point(int _X,int _Y)
        {
            X = _X;
            Y = _Y;
        }
        //Method
        public override string ToString()
        {
            return $" The X = {X}: Y = {Y}";
        }
        public void calculates()
        {
            if (X > Y)
                Console.WriteLine($"the distance between them is: {X-Y}");
            else 
                Console.WriteLine($"the distance between them is: {Y-X}");
        }
    }
}
