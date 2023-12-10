using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp18
{
    class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Time() { }
        public Time(int hours, int minutes) 
        {
            Hours = hours;
            Minutes = minutes;
        }
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public override string ToString()
        {
            return $"{Hours} часов и {Minutes} минут";
        }
        public void ToMinutes()
        {
            WriteLine($"Общее кол-во минут: {Hours * 60 + Minutes}");
        }
        public void ToSeconds()
        {
            WriteLine($"Общее кол-во секунд: {(Hours * 3600) + (Minutes * 60) + Seconds }");
        }
    }
}
