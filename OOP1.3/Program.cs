using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._3
{
    internal class Program
    {
        static void Main(string[] args) { 
            ClassA ObjA = new ClassA("*_*");
            ClassB ObjB = new ClassB("@_@");
            ObjA.Add(ObjB);
            Console.WriteLine(ObjA.ObjB.PropertyB);
        }

    }
}
