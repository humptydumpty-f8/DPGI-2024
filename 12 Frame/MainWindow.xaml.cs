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

namespace _12_Frame
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


        private void btnCheckBox_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Source = new Uri("CheckBoxPage.xaml",UriKind.RelativeOrAbsolute);//the second parameter is required!
        }

        private void btnRadio_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Source = new Uri("RadioButtonPage.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
