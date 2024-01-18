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

namespace _2._5.Використання_прикріплених_властивостей_при_розташуванні_елементів_в_сітці
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
        //Задаються нові розміри форми.
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Height = int.Parse(txtHeigt.Text);
            this.Width = int.Parse(txtWidth.Text);
        }
    }
}
