using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CBookCard
    {
        private string author;
        private string title;
        private string publishing;
        private int year;
        private int pages;
        private int tirage;
        private int rating;
        private string comment;

        public CBookCard() { }
        public CBookCard(string author) { this.Author = author; }
        public CBookCard(string author, string title) : this(author) { this.Title = title; }
        public CBookCard(string author, string title, string publishing) : this(author, title) { this.Publishing = publishing; }
        public CBookCard(string author, string title, string publishing, int year) : this(author, title, publishing) { this.Year = year; }
        public CBookCard(string author, string title, string publishing, int year, int pages) : this(author, title, publishing, year) { this.Pages = pages; }
        public CBookCard(string author, string title, string publishing, int year, int pages, int tirage) : this(author, title, publishing, year, pages) { this.Tirage = tirage; }
        public CBookCard(string author, string title, string publishing, int year, int pages, int tirage, int rating) : this(author, title, publishing, year, pages, tirage) { this.Rating = rating; }
        public CBookCard(string author, string title, string publishing, int year, int pages, int tirage, int rating, string comment) : this(author, title, publishing, year, pages, tirage, rating) { this.Comment = comment; }

        public string Author { get => author; set => author = value; }
        public string Title { get => title; set => title = value; }
        public string Publishing { get => publishing; set => publishing = value; }
        public int Year { get => year; set => year = value; }
        public int Pages { get => pages; set => pages = value; }
        public int Tirage { get => tirage; set => tirage = value; }
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
    }
}
