using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 pflfybbt
            /*
            Nums num1 = new Nums(7.5, 4.5);
            WriteLine(num1.ToString());
            num1.Root();*/

            //2
            /*
            Time time1 = new Time(2, 30);
            time1.ToMinutes();
            Time time2 = new Time(3, 1, 42);
            time2.ToSeconds();*/
            //3
            /*
            Triangle abc = new Triangle(1, 2, 3);
            WriteLine(abc.ToString());
            abc.Per();
            Triangle zxc = new Triangle(5);
            WriteLine(zxc.ToString());
            zxc.Per();*/
            //4
            /*
            Car car1 = new Car("Жигули", "2104", 123);
            car1.Start();
            car1.Stop();*/
            //5
            Newspaper n1 = new Newspaper();
            n1.Init();
            n1.Info();
            n1.ChangeName();
            n1.ChangeNumber();
            n1.Info();
            ReadKey();
        }

    }
}
