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

namespace _3._4.DockPanel_в_макеті_простого_редактора
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string tmp;
        public MainWindow()
        {
            InitializeComponent();            
        }

       
        private void btnConsole_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = string.Empty;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox.Text!=string.Empty) tmp = txtBox.Text;
        }
    }
}
