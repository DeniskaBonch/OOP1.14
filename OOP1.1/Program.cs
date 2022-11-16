using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassB ObjB = new ClassB("*_*");
            ClassA ObjA = new ClassA("<3") { B = ObjB };
            Console.WriteLine(ObjA.B.PropertyB);
        }

    }
}
