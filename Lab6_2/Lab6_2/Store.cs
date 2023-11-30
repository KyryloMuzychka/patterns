using Lab6_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    public class Store
    {
        private Book book1, book2, book3, book4, book5;
        public static List<string> typesIterators;
        public static BookList library;


        private Store()
        {
            book1 = Book.CreateBook("Author1", "Book1", "Publisher1", 2010);
            book2 = Book.CreateBook("Author2", "Book2", "Publisher3", 2000);
            book3 = Book.CreateBook("Author1", "Book1", "Publisher1", 2005);
            book4 = Book.CreateBook("Author3", "Book3", "Publisher2", 2030);
            book5 = Book.CreateBook("Author2", "Book4", "Publisher1", 2025);

            library = BookList.CreateBookList();

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            typesIterators = new List<string>(){ "Author Iterator", "Year Iterator", "Publication Iterator" };           
        }  
        
        public static Store CreateStore()
        {
            return new Store();
        }
    }
}
