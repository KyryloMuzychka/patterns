using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    public class Book
    {
        static private int index = 0;

        public string Authors { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        private int uii;

        Book(string authors, string title, string publisher, int year)
        { 
            this.Authors = authors;
            this.Title = title;
            this.Publisher = publisher;
            this.Year = year;
            this.uii = index++;            
        }

        public int GetBookIndex()
        {
            return uii;
        }

        public static Book CreateBook(string authors, string title, string publisher, int year)
        {
            return new Book(authors, title, publisher, year);
        }
    }
}
