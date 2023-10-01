using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Bookshelf
{
    /// <summary>
    /// Логика взаимодействия для WAddBook.xaml
    /// </summary>
    public partial class WAddBook : Window
    {
        public WAddBook()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void bt_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_Add_Book_Click(object sender, RoutedEventArgs e)
        {
            string author = tb_Author.Text + "";
            string title = tb_Title.Text + "";
            string filename = "none";
            byte[] filedata = { 0, 1 };
            DbHelper.AddBooks(author, title, filename, filedata);
            this.Close();
        }
    }
}
