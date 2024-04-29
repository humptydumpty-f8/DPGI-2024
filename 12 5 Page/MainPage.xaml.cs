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

namespace _12_5_Page
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCheckBox_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Source = new Uri("CheckBoxPage.xaml", UriKind.RelativeOrAbsolute);
        }

        private void btnRadio_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Source = new Uri("RadioButtonPage.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
