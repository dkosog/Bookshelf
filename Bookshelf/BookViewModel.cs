using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Bookshelf
{
    class BookViewModel : INotifyPropertyChanged
    {
        private Book book;

        public BookViewModel(Book b)
        {
            book = b;
        }

        public int Id 
        { 
            get { return book.Id; }
            
            set 
            { 
                book.Id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Author
        {
            get { return book.Author; }

            set
            {
                book.Author = value;
                OnPropertyChanged("Author");
            }
        }

        public string Title
        {
            get { return book.Title; }

            set
            {
                book.Title = value;
                OnPropertyChanged("Title");
            }
        }

        public string FileName
        {
            get { return book.FileName; }

            set
            {
                book.FileName = value;
                OnPropertyChanged("FileName");
            }
        }

        public byte[] FileData
        {
            get { return book.FileData; }

            set
            {
                book.FileData = value;
                OnPropertyChanged("FileData");
            }
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
