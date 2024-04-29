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
    /// Логика взаимодействия для CheckBoxPage.xaml
    /// </summary>
    public partial class CheckBoxPage : Page
    {
        public CheckBoxPage()
        {
            InitializeComponent();
        }

        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox1.Content.ToString() + " --> не відмічений");
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox1.Content.ToString() + " --> відмічений");
        }

        private void checkBox1_Indeterminate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox1.Content.ToString() + " --> стан невизначений");
        }
    }
}
