using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CBookCard book = new CBookCard("Пушкин", "Онегин", "Какое-то", 1833, 300, 50000);
            Console.WriteLine($"{book.ToString()}");
            Console.ReadLine();
        }
    } 
}
