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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _12_8_WebBrowser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            myBrowser.Navigate(new Uri("http://www.google.com"));  
        }
        
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            if (myBrowser.CanGoBack)
            {
                myBrowser.GoBack();
            }
            else
            {
                MessageBox.Show("Cannot Go back");
            }
        }
        
        private void GoForward_Click(object sender, RoutedEventArgs e)
        {
            if (myBrowser.CanGoForward)
            {
                myBrowser.GoForward();
            }
            else
            {
                MessageBox.Show("Cannot Go Forward");
            }
        }
    }
}
