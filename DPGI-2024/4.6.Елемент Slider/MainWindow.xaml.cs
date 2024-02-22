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

namespace _4._6.Елемент_Slider
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

        private void sldSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtText.FontSize = sldSize.Value;
            lblFontSize.Content = Convert.ToString(txtText.FontSize);
            ((Slider)sender).SelectionEnd = e.NewValue;
        }
    }
}
