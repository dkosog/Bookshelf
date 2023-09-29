using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshelf
{
    internal class Books
    {
        public Books(int id, string author, string title, string filename)
        {
            Id = id;
            Author = author;
            Title = title;
            FileName = filename;
        
        }

        public Books(int id, string author, string title, string filename, byte[] filedata)
        {
            Id = id;
            Author = author;
            Title = title;
            FileName = filename;
            FileData = filedata;

        }

        private int id;
        private string? author;
        private string? title;
        private string? fileName;
        private byte[]? fileData;

        public int Id
        { 
            get { return id; }
            set { id = value; } 
        }
        
        public string? Author 
        { 
            get { return author; }
            set { author = value; }
        }
        
        public string? Title 
        {
            get { return title; }
            set {  title = value; }
        }
        
        public string? FileName
        { 
            get { return fileName; }
            set {  fileName = value; }
        }
        
        public byte[]? FileData 
        { 
            get { return fileData; }
            set {  fileData = value; }
        }

    }
}
