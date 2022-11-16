using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1
{
    public class ClassA
    {
        public string PropertyA { get; set; }
        public ClassA(string PropertyA)
        {
            this.PropertyA = PropertyA;
        }
       public ClassB B { get; set; }
    }
}

