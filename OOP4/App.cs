using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    public class App
    {
        public App(string NameApp)
        {
            this.NameApp = NameApp;
        }
        public string NameApp { get; set; }
        public override string ToString()
        {
            return NameApp;
        }
    }

}
