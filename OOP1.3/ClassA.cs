using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._3
{
    public class ClassA
    {
        public ClassA(string PropertyA)
        {
            this.PropertyA = PropertyA;
        }
        public string PropertyA { get; set; }
        public ClassB ObjB { get; set; }

        public void Add(ClassB ObjB)
        {
            this.ObjB = ObjB;
        }
    }

}
