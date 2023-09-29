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
        }

        
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //books.Add(new Books() { Id = 1, Author = "Author_1", Title = "Book_1", FileName = string.Empty, FileData = null });
            //books.Add(new Books() { Id = 2, Author = "Author_2", Title = "Book_2", FileName = string.Empty, FileData = null });
            List<Books> books = new List<Books>();
            books =DbHelper.GetBooks();
            MainDG.ItemsSource = books;

        }

        private void bt_Add_Click(object sender, RoutedEventArgs e)
        {
            DbHelper.CreateDB();
        }

        private void bt_Del_Click(object sender, RoutedEventArgs e)
        {
            int result = MainDG.Items.IndexOf(MainDG.SelectedCells[0].Item);
            
            MessageBox.Show(result.ToString());


        }
    }
}
