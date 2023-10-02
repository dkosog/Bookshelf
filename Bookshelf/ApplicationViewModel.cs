using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bookshelf
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        private byte[] mbt = { 0, 1, 2 }; 
        
        private Book selectedBook;
        
        public ObservableCollection<Book> Books { get; set; }

        public Book SelectedBook
        { 
        get { return selectedBook; }
            set
            {
                selectedBook = value;
                OnPropertyChanged("SelectedBook");
            }
        }

        public ApplicationViewModel()
        {
            Books = new ObservableCollection<Book>
            {
                new Book { Id = 1, Author = "Author1", Title = "Book_name_1", FileName = "\\temp\\book.txt", FileData = mbt },
                new Book { Id = 2, Author = "Author2", Title = "Book_name_2", FileName = "\\temp\\book1.txt", FileData = mbt },
                new Book { Id = 3, Author = "Author3", Title = "Book_name_3", FileName = "\\temp\\book3.txt", FileData = mbt },
                new Book { Id = 4, Author = "Author4", Title = "Book_name_4", FileName = "\\temp\\book4.txt", FileData = mbt },
                new Book { Id = 5, Author = "Author_5", Title = "Book_name_5", FileName = "\\temp\\book_5.txt", FileData = mbt }
            };
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
