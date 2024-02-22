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

namespace _4._1.Мнемонічні_команди__створення_груп
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (txtLogin.Text != String.Empty && pswPassword.Password != String.Empty)
                MessageBox.Show($"Login: {txtLogin.Text}; Password: {pswPassword.Password}");
        }

        private void btnConsole_Click(object sender, RoutedEventArgs e)
        {
            txtLogin.Text = String.Empty;
            pswPassword.Password = String.Empty;
        }
    }
}
