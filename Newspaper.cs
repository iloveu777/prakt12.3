using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp18
{
    class Newspaper
    {
        public string Name { get; set; }
        public int Tiraj { get; set; }
        public int NumOfPaper { get; set; }
        public Newspaper() { }
        public Newspaper(string name, int tiraj, int numOfPaper) 
        {
            Name = name;
            Tiraj = tiraj;
            NumOfPaper = numOfPaper;
        }
        public void Init()
        {
            Write("Введите название газеты: ");
            Name = ReadLine();
            Write("Введите тираж: ");
            Tiraj = int.Parse(ReadLine());
            Write("Введите количество страниц(полос): ");
            NumOfPaper = int.Parse(ReadLine());
        }
        public void Info()
        {
            WriteLine($"Название: {Name}, тираж: {Tiraj}, кол-во страниц: {NumOfPaper}");
        }
        public void ChangeName()

        {
            WriteLine($"Введите новое имя для газеты {Name}");
            string namee = ReadLine();
            WriteLine($"Имя газеты изменено с {Name} на {namee}");
            Name = namee;
            
        }
        public void ChangeNumber()
        {
            WriteLine($"Введите новое кол-во страниц для газеты {Name}. Текущее значение {NumOfPaper}");
            int nums = int.Parse(ReadLine());
            WriteLine($"Кол-во страниц изменено с {NumOfPaper} на {nums}");
            NumOfPaper = nums;

        }
    }
}
