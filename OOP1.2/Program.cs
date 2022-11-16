using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ClassB ObjB = new ClassB("-_-");
            ClassA ObjA = new ClassA("<3") { B = ObjB };
            ClassB ObjB2 = new ClassB("*_*") { A = ObjA };
            Console.WriteLine(ObjA.B.PropertyB);
            Console.WriteLine(ObjB2.A.PropertyA);
        }

    }
}
