using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ClassA ObjA = new ClassA("@_@");

            Console.WriteLine(ObjA.ObjB.PropertyB);
        }

    }
}
