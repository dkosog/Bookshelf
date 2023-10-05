using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Bookshelf
{
    internal class ViewModel : INotifyPropertyChanged
    {
        private Book selectedBook;
        public ObservableCollection<Book> Books { get; set; }
        private RelayCommand addCommand;
        private byte[] bb = {0,1};
        
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Book book = new Book();
                      Books.Add(book);
                      SelectedBook = book;
                  }));
            }
        }


        public Book SelectedBook
        {  
            get { return selectedBook; } 
            set 
            { 
                selectedBook = value; 
                OnPropertyChanged("SelectedBook");
            }
        }

        public ViewModel()
        {
            Books = new ObservableCollection<Book>
            { 
                new Book { Id = 1, Author = "Au11", Title = "tt1", FileName = "none" },
                new Book { Id = 2, Author = "Au22", Title = "tt22", FileName = "none"},
                new Book { Id = 3, Author = "Au311", Title = "tt331", FileName = "none" }

                };

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        //
    }
}
