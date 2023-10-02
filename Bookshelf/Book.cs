using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bookshelf
{
    internal class Book : INotifyPropertyChanged
    {
        private int id;
        private string? author;
        private string? title;
        private string? fileName;
        private byte[]? fileData;

        public int Id
        { 
            get { return id; }
            set { id = value;
                OnPropertyChanged("Id");
            } 
        }
        
        public string? Author 
        { 
            get { return author; }
            set { author = value;
                OnPropertyChanged("Author");
            }
        }
        
        public string? Title 
        {
            get { return title; }
            set {  title = value;
                OnPropertyChanged("Title");
            }
        }
        
        public string? FileName
        { 
            get { return fileName; }
            set {  fileName = value;
                OnPropertyChanged("FileName");
            }
        }
        
        public byte[]? FileData 
        { 
            get { return fileData; }
            set {  fileData = value;
                OnPropertyChanged("FileData");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged ([CallerMemberName]string prop="")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
