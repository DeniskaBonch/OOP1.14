using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    public class Computer
    {
        public Computer(string Name)
        {
            this.Name = Name;
        }
        public string Name { get; set; }
        public List<App> Coll { get; set; } = new List<App>();
        public void Add(App app)
        {
            Coll.Add(app);
        }
        public override string ToString()
        {
            return Name + ", " + String.Join(", ", Coll);
        }
    }

}
