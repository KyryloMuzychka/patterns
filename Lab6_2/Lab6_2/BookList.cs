using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    public class BookList : IEnumerable<Book>
    {
        private List<Book> books = new List<Book>();

        public List<Book> GetListBooks()
        {
            return books;
        }

        // Додавання книги
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        // Видалення книги
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public int Count => books.Count;
      
        public IEnumerator<Book> GetEnumerator()
        {
            return books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Ітератор для отримання книг певного автора
        public BookListIterator GetAuthorIterator(string _author)
        {
            return new BookListIterator(this, author: _author);
        }

        // Ітератор для отримання відсортованого за роком видавництва списку книг
        public BookListIterator GetYearIterator()
        {
            return new BookListIterator(this, year: true);
        }

        // Ітератор для отримання інформації про публікації книги
        public BookListIterator GetPublicationIterator(string _title)
        {
            return new BookListIterator(this, title: _title);
        }
     
        public void AddRange(IEnumerable<Book> books)
        {
            this.books.AddRange(books);
        }

        public static BookList CreateBookList()
        {
            return new BookList();
        }
    }
}
