using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Software
    {
        private string name;
        private string manufacturer;
        private bool poidfree;

        public string Name {get {return (name != "") ? name : "Неизвестно"; } set => name = value; }
            
        public string Manufacturer {get {return (manufacturer != "") ? manufacturer : "Неизвестно"; } set => manufacturer = value; }
        public bool Poidfree { get => poidfree; set => poidfree = value; }

        public Software() {}
        public Software(string name, string  manufacturer, bool poidfree)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Poidfree = poidfree;
        }
        public override string ToString()
        {
            return $"Название:{Name}\nПроизводитель:{Manufacturer}\n{(Poidfree ? "Бесплатное" : "Платное")}";
        }
        public void Change()
        {
            Poidfree = !Poidfree;
        }
        public void Check()
        {
            if(!Poidfree)
            {
                Console.WriteLine("ПО платное");
            }
            else
            {
                Console.WriteLine("ПО бесплатное");
            }
        }
    }
}
