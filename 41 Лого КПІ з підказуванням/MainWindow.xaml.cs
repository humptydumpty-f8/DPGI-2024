using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace _41_Лого_КПІ_з_підказуванням
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

        private void hlKpi_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://kpi.ua/");
        }

        private void hlCte_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://dte.kpi.ua/");
        }
    }
}
