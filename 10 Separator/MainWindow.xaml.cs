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

namespace _10_Separator
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

        private void RedMenuItem_Click(object sender, RoutedEventArgs e)
        {
            canvas.Background = Brushes.Red;
        }

        private void GreenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            canvas.Background = Brushes.Green;
        }

        private void OrangeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            canvas.Background = Brushes.Orange;
        }
    }
}
