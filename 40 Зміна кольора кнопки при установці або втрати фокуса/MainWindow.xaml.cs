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

namespace _40_Зміна_кольора_кнопки_при_установці_або_втрати_фокуса
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


        private void btnOk_GotFocus(object sender, RoutedEventArgs e)
        {
            btnOk.Background = Brushes.Red;
        }

        private void btnOk_LostFocus(object sender, RoutedEventArgs e)
        {
            btnOk.Background = SystemColors.ControlBrush;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Login: {txtLog.Text}\nPassword: {psvBox.Password}", this.Title);
        }
    }
}
