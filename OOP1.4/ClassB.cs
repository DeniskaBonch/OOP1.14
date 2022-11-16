using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._4
{
    public class ClassB
    {
        public ClassB(string PropertyB)
        {
            this.PropertyB = PropertyB;
        }
        public string PropertyB { get; set; }

        public ClassA ObjA { get; set; }
    }

}
