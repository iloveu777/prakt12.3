using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp18
{
    class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle() { }
        public Triangle(double a, double b, double c) 
        {
            A = a;
            B = b;
            C = c;

        }
        public Triangle(double aaa)
        {
            A = aaa;
            B = aaa;
            C = aaa;
        }
        public override string ToString()
        {
            return $"Длина стороны A - {A}, Длина стороны B - {B}, Длина стороны C - {C}";
        }
        public void Per()
        {
            WriteLine($"Периметр треугольника = {A+ B +C}");
        }
    }
}
