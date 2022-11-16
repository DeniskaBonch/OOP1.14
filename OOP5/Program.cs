using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer("Denis");
            computer.New("First");
            computer.New("Second");
            computer.New("Third");
            Console.WriteLine(computer);
        }

    }
}
