using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp18
{
    class Car
    {
        public string CarMake { get; set; }
        public string Model { get; set; }
        public int Number { get; set; }
        public Car() { }
        public Car(string carMake, string model, int number) 
        {
            CarMake = carMake;
            Model = model;
            Number = number;
        }
        public void Start()
        {
            WriteLine($"Машина {CarMake} {Model} с номером {Number} завелась");
        }
        public void Stop()
        {
            WriteLine($"Машина {CarMake} {Model} с номером {Number} остановилась");
        }

    }
}
