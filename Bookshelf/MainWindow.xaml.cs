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
            DataContext = new ViewModel();
        }
        
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           
        }

        private void bt_Add_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void bt_Del_Click(object sender, RoutedEventArgs e)
        {
                        
        }

       }
}
