using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyVector;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing MyVector.dll");
            Vector Vector = new Vector(20, 20);
            Console.WriteLine("Length equals: " + Vector.length());
            Console.ReadKey();
        }
    }
}
