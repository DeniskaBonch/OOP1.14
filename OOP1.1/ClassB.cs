using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1
{
    public class ClassB 
    {
        public string PropertyB;
        public ClassB(string PropertyB)
        {
            this.PropertyB = PropertyB;
        }

        public ClassA ClassA
        {
            get => default;
            set
            {
            }
        }
    }
}
