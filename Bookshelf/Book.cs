using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Bookshelf
{
    internal class Book : INotifyPropertyChanged
    {
        //public Book(int id, string author, string title, string filename)
        //{
        //    Id = id;
        //    Author = author;
        //    Title = title;
        //    FileName = filename;
        //}

        //public Book(int id, string author, string title, string filename, byte[] filedata)
        //{
        //    Id = id;
        //    Author = author;
        //    Title = title;
        //    FileName = filename;
        //    FileData = filedata;
        //}

        private int id;
        private string? author;
        private string? title;
        private string? filename;
        //private byte[]? filedata;

        public int Id
        { 
            get { return id; }
            set 
            {
                id = value;
                OnPropertyChanged("Id");
            } 
        }
        
        public string? Author 
        { 
            get { return author; }
            set 
            {
                author = value;
                OnPropertyChanged("Author");
            }
        }
        
        public string? Title 
        {
            get { return title; }
            set 
            {  
                title = value;
                OnPropertyChanged("Title");
            }
        }
        
        public string? FileName
        { 
            get { return filename; }
            set 
            { 
                filename = value;
                OnPropertyChanged("FileName");
            }
        }
        
        //public byte[]? FileData 
        //{ 
        //    get { return filedata; }
        //    set 
        //    {  
        //        filedata = value;
        //        OnPropertyChanged("FileData");
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        //public ObservableCollection<Books> Obooks { get; set; }

    }
}
