using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Edition titl1 = new Edition();
            titl1.Title = "Няня";
            titl1.Surname = "Пушкин";
            titl1.Year = 1826;
            Console.WriteLine($"{titl1.ToString()}");
            Console.WriteLine();

            /*Edition titl2 = new Edition("Евгений Онегин")*/;
            //Edition titl2 = new Edition("Евгений Онегин", "Пушкин");
            Edition titl2 = new Edition("Евгений Онегин", "Пушкин", 1833);
            Console.WriteLine($"{titl2.ToString()}");
            Console.WriteLine();

            Console.Write("Название: ");
            string Title = (Console.ReadLine());
            Console.Write("Фамилия писателя: ");
            string Surname = (Console.ReadLine());
            Console.Write("Год выпуска: ");
            int Year = int.Parse(Console.ReadLine());
            Edition titl3 = new Edition(Title, Surname, Year);
            Console.WriteLine($"{titl3.ToString()}");
            titl3.Interval(Year);
            Console.ReadLine();
        }
    }
}
