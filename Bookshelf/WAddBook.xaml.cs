using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Collections.ObjectModel;

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
            DataContext = this;
            
        }
        
        
        private void bt_Cancel_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            this.DialogResult = false;
        }

        private void bt_Add_Book_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            //this.Close();
        }
    }
}
