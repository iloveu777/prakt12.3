using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp18
{
    class Nums
    {
        public double Num1 { get; set; }
        
        public double Num2{ get; set; }
        public Nums() { }
        public Nums(double num1, double num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }
        /*   public void Info()
           {
               WriteLine($"1 число: {Num1}, 2 число: {Num2}");

           }*/
        public override string ToString()
        {
            return $"1 число: {Num1}, 2 число: {Num2}";
                
            
        }
        public void Root()
        {
            WriteLine($"Корень из произведения чисел {Num1} и {Num2} = {Math.Sqrt(Num1 * Num2)}");
        }
    }
}
