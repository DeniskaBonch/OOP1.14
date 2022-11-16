using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<App> Arr = new List<App>()
            {
                new App ("First"),
                new App("Second"),
                new App("Thirth"),
                new App("Fourth"),
                new App("Fifth")
            };
            Computer computer = new Computer("Denis");
            computer.Coll = Arr;
            Console.WriteLine(computer.ToString());
        }

    }
}
