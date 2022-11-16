using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using OOP3;

namespace OOP3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer("Denis");

            List<App> Arr = new List<App>()
            {
                new App ("First"),
                new App ("Second"),
                new App("Third")
            };
            computer.Coll = Arr;
            Console.WriteLine(computer.ToString());
        }


    }
}
