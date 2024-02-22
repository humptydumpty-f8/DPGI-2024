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

namespace _3._5.Комбінування_контейнерів
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String buff;
        public MainWindow()
        {
            InitializeComponent();
            buff = this.Title;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Title = txtTitle.Text;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Title = buff;
        }
    }
}
