using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Edition
    {
        private string title;
        private string surname;
        private int year;

        public string Title { get { return (title != "") ? title : "Неизвестно"; } set => title = value; }
        public string Surname { get { return (surname != "") ? surname : "Неизвестно"; } set => surname = value; }
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1990)
                    year = 1990;
                else if (value > 2024)
                    year = 2024;
                else year = value;
            }
        }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Edition()
        { }
        /// <summary>
        /// Констуктор с одним параметром
        /// </summary>
        /// <param name="title"></param>
        public Edition(string title)
        {
            this.Title = title;
        }
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="title"></param>
        /// <param name="surname"></param>
        public Edition(string title, string surname) : this(title)
        {
            this.Surname = surname;
        }
        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="title"></param>
        /// <param name="surname"></param>
        /// <param name="year"></param>
        public Edition(string title, string surname, int year) : this(title, surname)
        {
            this.Year = year;
        }
        public override string ToString()
        {
            return $"Название: {Title}\nАтор: {Surname}\nГод издания: {Year}г";
        }
        /// <summary>
        /// Изменить год издания, увеличив или уменьшив его на указанное число лет
        /// </summary>
        public void Years(int years)
        {


        }
        public void Interval(int year)
        {
           if (year>1990 && year < 2024)
            {
            Console.WriteLine("Входит");
            }
            else
            {
              Console.WriteLine ("Не входит");
            }
        }
    } 
}

