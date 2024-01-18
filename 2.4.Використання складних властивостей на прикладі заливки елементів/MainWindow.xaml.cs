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

namespace _2._4.Використання_складних_властивостей_на_прикладі_заливки_елементів
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

        //Обробник події кліку по кнопці.
        //Виводить діалог з повідомленням про клік.
        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button was clicked");
        }
    }
}
