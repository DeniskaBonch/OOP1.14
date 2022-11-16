using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tim
{
    public class Film : cinema
    {
        public string name { get; set; }
        public string time { get; set; }
        public int duration { get; set; }

        public Film(string Name, string Time, int Duration)
        {
            this.name = Name;
            this.time = Time;
            this.duration = Duration;
        }
        public Film Clone()
        {
            Film a2 = new Film(name, time, duration);
            return a2;
        }
        public override string ToString()
        {
            return $"Название фильма - {name} Стоимость билета {time}. продолжительность фильма - {duration} минут.";
        }
    }



}
