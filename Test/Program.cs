using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot bot = new Robot("Bot", 800, 100, new byte[] { 5, 3, 10 });
            bot.Print();
            Console.WriteLine();

            Robot healer = new Robot("Healer", 400, 200, new byte[] { 0, 0, 2 });
            healer.Print();
            Console.WriteLine();

            Robot killer = new Robot("Killer", 1500, 50, new byte[] { 10, 10, 10 });
            killer.Print();
            Console.WriteLine();

            Robot eng = new Robot();
            eng.SetValues("Eng", 2000, 120, new byte[] { 20, 30, 0 });
            eng.Print();
            Console.WriteLine();
            Console.Write("Count of Robots: ");
            Console.WriteLine(Robot.cnt);
        }
    }
}
