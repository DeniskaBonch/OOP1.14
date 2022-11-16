using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class App
    {
        public App(string NameApp)
        {
            this.NameApp = NameApp;
        }
        private string NameApp {get; set; }

        public override string ToString()
        {
            return NameApp;
        }
    }

}
