using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    internal class Logic
    {
        public static void DeleteElement(int index)
        {
            for (int i = 0; i < Store.library.Count; i++)
                if (index == Store.library.GetListBooks()[i].GetBookIndex())
                    Store.library.GetListBooks().RemoveAt(i);
        }

        public static List<Book> GetSortedBookList(string type, string value = null)
        {
            BookListIterator iterator = null;
            if (type == "Author Iterator")
            {
                iterator = Store.library.GetAuthorIterator(value);                                    
            }
            else if (type == "Year Iterator")
            {
                iterator = Store.library.GetYearIterator();
            }
            else if (type == "Publication Iterator")
            {
                iterator = Store.library.GetPublicationIterator(value);
            }
            return iterator.resultBookList.GetListBooks();
        }
    }
}
