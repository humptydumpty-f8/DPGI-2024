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

namespace _46Slider_4_RGB
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double colorR;
        double colorG;
        double colorB;

        public MainWindow()
        {
            InitializeComponent();
            colorR = slR.Value;
            colorG = slG.Value;
            colorB = slB.Value;
        }

        private void slR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            colorR = ((Slider)sender).Value;
            Color color = Color.FromRgb((byte)colorR, (byte)colorG, (byte)colorB);
            this.Background = new SolidColorBrush(color);
        }

        private void slG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            colorG = slG.Value;
            Color color = Color.FromRgb((byte)colorR, (byte)colorG, (byte)colorB);
            this.Background = new SolidColorBrush(color);
        }

        private void slB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            colorB = slB.Value;
            Color color = Color.FromRgb((byte)colorR, (byte)colorG, (byte)colorB);
            this.Background = new SolidColorBrush(color);
        }
    }
}
