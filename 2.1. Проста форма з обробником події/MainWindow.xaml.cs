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

namespace _2._1.Проста_форма_з_обробником_події
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
        //Обробник події завантаження.
        //Виводить діалог з розмірами вікна (px).
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format("Window sizes: \n {0}x{1}", this.ActualHeight, this.ActualWidth));
        }

        
    }
}
