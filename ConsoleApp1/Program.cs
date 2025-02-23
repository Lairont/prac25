using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Software soft1 = new Software("Windows", "Microsoft", false);
            Console.WriteLine($"{soft1.ToString()}");
            soft1.Check();
            Console.WriteLine();
            soft1.Change();
            Console.WriteLine($"{soft1.ToString()}");
            soft1.Check();
            Console.ReadLine();
        }
    }
}
