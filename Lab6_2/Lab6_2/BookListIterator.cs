using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    public class BookListIterator
    {        
        public BookList resultBookList;

        public BookListIterator(BookList bookList, string author = null, bool year = false, string title = null)
        {
            resultBookList = new BookList();
            if (author != null)
            {
                // Отримуємо книжки одного автора
                resultBookList.AddRange(bookList.Where(book => book.Authors.Contains(author)));                              
            }
            else if (year)
            {
                // Сортуємо за роком видавництва                
                resultBookList.AddRange(bookList.OrderBy(b => b.Year));
            }
            else if (title != null)
            {
                // Список всіх публікацій                
                resultBookList.AddRange(bookList.Where(book => book.Title == title));                              
            }            
        }      
    }
}
