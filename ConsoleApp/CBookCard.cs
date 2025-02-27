using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class CBookCard
    {
        private string author;
        private string title;
        private string publisher;
        private int year;
        private int pages;
        private int edition;
        private int rating;
        private string comment;

        public CBookCard()
        { }
        public CBookCard(string author, string title, string publisher, int year, int pages, int edition)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.year = year;
            this.pages = pages;
            this.edition = edition;
        }

        public string Author { get => author; set => author = value; }
        public string Title { get => title; set => title = value; }
        public string Publishing { get => publisher; set => publisher = value; }
        public int Year { get => year; set => year = value; }
        public int Pages { get => pages; set => pages = value; }
        public int Edition { get => edition; set => edition = value; }
        public int Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if (value < 0)
                {
                    rating = 0;
                }
                else if (value > 100)
                {
                    year = 100;
                }
                else year = value;
            }

        }
        public string Comment { get => comment; set => comment = value; }


        public override string ToString()
        {
            return $"{author}\n{title}\n{publisher}\n{year}г\n{pages} страниц\nТираж: {edition}\nРейтинг:{rating}\n{comment}";
        }
    }
}
