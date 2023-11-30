using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_2
{
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
            Store.CreateStore();
            InitializeComboBox();
            InitializeListView();
            UpdatePositionsListView(BookListView, Store.library.GetListBooks());           
        }


        void InitializeComboBox()
        {
            foreach (var iterator in Store.typesIterators)
            {
                IteratorComboBox.Items.Add(iterator);
            }
        }


        void InitializeListView()
        {
            BookListView.Columns.Add("Title", 100, HorizontalAlignment.Left);
            SortedBooksListView.Columns.Add("Title", 100, HorizontalAlignment.Left);
            BookListView.Columns.Add("Authors", 100, HorizontalAlignment.Left);
            SortedBooksListView.Columns.Add("Authors", 100, HorizontalAlignment.Left);
            BookListView.Columns.Add("Year", 100, HorizontalAlignment.Left);
            SortedBooksListView.Columns.Add("Year", 100, HorizontalAlignment.Left);
            BookListView.Columns.Add("Publisher", 150, HorizontalAlignment.Left);
            SortedBooksListView.Columns.Add("Publisher", 150, HorizontalAlignment.Left);
            BookListView.Columns.Add("Code", 70, HorizontalAlignment.Left);
            SortedBooksListView.Columns.Add("Code", 70, HorizontalAlignment.Left);
        }


        private void UpdatePositionsListView(ListView list, List<Book> books)
        {
            list.Items.Clear();
            foreach (var book in books)
            {             
                ListViewItem item = new ListViewItem(book.Title);
                item.SubItems.Add(book.Authors);
                item.SubItems.Add(book.Year.ToString());
                item.SubItems.Add(book.Publisher);
                item.SubItems.Add(book.GetBookIndex().ToString());
                list.Items.Add(item);
            }
        }


        private void RemoveBookButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DeleteEdit.Text, out int index))
            {
                Logic.DeleteElement(index);
                UpdatePositionsListView(BookListView, Store.library.GetListBooks());
            }
        }


        private void AddBookEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(YearEdit.Text, out int year) &&
                !string.IsNullOrEmpty(TitleEdit.Text) &&
                !string.IsNullOrEmpty(AuthorEdit.Text) &&
                !string.IsNullOrEmpty(PublisherEdit.Text) )
                
            {
                string title = TitleEdit.Text;
                string author = AuthorEdit.Text;
                string publisher = PublisherEdit.Text;
                Store.library.AddBook(Book.CreateBook(author, title, publisher, year));
                UpdatePositionsListView(BookListView, Store.library.GetListBooks());
            }            
        }

        private void IteratorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = SortingParameterEdit.Text;
            List<Book> list = Logic.GetSortedBookList(IteratorComboBox.SelectedItem.ToString(), value);                        
            UpdatePositionsListView(SortedBooksListView, list);
        }
    }
}
