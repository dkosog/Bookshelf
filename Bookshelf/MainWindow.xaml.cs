using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Reflection.Metadata.BlobBuilder;
using System.Collections.ObjectModel;


namespace Bookshelf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        
        List<Books> books = new List<Books>();
        ObservableCollection<Books> Obooks = new ObservableCollection<Books>();


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //books.Add(new Books() { Id = 1, Author = "Author_1", Title = "Book_1", FileName = string.Empty, FileData = null });
            //books.Add(new Books() { Id = 2, Author = "Author_2", Title = "Book_2", FileName = string.Empty, FileData = null });
            ReloadDG();

        }

        private void bt_Add_Click(object sender, RoutedEventArgs e)
        {
            ////DbHelper.CreateDB();
            //byte[] bb = { 0, 1 };
            //DbHelper.AddBooks("added_author", "add_book", "", bb);
            //ReloadDG();
            WAddBook wAddBook= new WAddBook();
            wAddBook.Owner = this;
            wAddBook.ShowDialog();
        }

        private void bt_Del_Click(object sender, RoutedEventArgs e)
        {
            if (MainDG.SelectedItem != null) 
            {
                int item = (MainDG.SelectedItem as Books).Id;
                //MessageBox.Show("Будет удален Id=" + item.ToString());

                if (MessageBox.Show("Запись будет удалена, Id=" + item.ToString(), "Удалить",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    DbHelper.DelBooks(item);
                    ReloadDG();
                }
            }
                
                      
            
        }

        public void ReloadDG()
        {
            
            Obooks.Clear();
            books = DbHelper.GetBooks();
            foreach (Books book in books) 
            {
                Obooks.Add(book);
            }
            MainDG.ItemsSource = Obooks;
        }
    }
}
