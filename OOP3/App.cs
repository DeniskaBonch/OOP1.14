using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class App
    {
        public App(string UserName)
        {
            NameApp = UserName;
        }
        public string NameApp { get; set; }
        public Computer UserName { get; set; }


        public override string ToString()
        {
            return NameApp;
        }
    }


}
