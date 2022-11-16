using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._2
{
    public class ClassA
    {
        public string PropertyA { get; set; }
        public ClassA(string PropertyA)
        {
            this.PropertyA = PropertyA;
        }
        public ClassB B { get; set; }

        public ClassB ClassB
        {
            get => default;
            set
            {
            }
        }
    }
}

