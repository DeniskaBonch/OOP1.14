using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    public class App
    {
        public string NameApp { get; set; }


        public App(string NameApp)
        {
            this.NameApp = NameApp;
        }
        public override string ToString()
        {
            return NameApp;
        }
    }

}
