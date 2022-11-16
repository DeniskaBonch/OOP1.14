using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Robot
    {
        private string name;
        private int weight;
        private byte age;
        private byte[] coords;

        public Robot(string name, int weight, byte age, byte[] coords)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            this.coords = coords;
            Console.WriteLine("New Robot!");
            cnt++;
        }
        public Robot() { Console.WriteLine("New Robot!"); cnt++; }

        public static int cnt;

        public void SetValues(string _name, int _weight, byte _age, byte[] _coords)
        {
            name = _name;
            weight = _weight;
            age = _age;
            coords = _coords;
        }
        public void Print()
        {
            Console.WriteLine(name + " weight = " + weight + " age = " + age + ". Coords:");
            foreach(byte el in coords)
                Console.WriteLine(el);
        }
    }
}
