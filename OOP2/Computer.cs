using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Computer
    {
        public Computer(string Name)
        {
            this.Name = Name;
        }
        private string Name { get; set; }

        public List<App> Coll { get; set; }
        public override string ToString()
        {
            return Name + ", " + String.Join(", ", Coll);
        }
    }

}
