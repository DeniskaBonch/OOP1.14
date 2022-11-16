using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._4
{
    public class ClassA
    {
        public ClassA(string PropertyA)
        {
            this.PropertyA = PropertyA;
            ObjB = new ClassB("*_*");
        }
        private string PropertyA { get; set; }
        public ClassB ObjB { get; set; }
    }

}
