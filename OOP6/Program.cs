using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer("Denis");
            List<App> Arr = new List<App>()
            {
                new App ("First"),
                new App ("Secondly"),
                new App("Third")
            };
            foreach (App el in Arr)
            {
                computer.Add(el);
            }
            Console.WriteLine(computer.ToString());
        }

    }
}
