using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UniformGrid uniformGrid = new UniformGrid();
            uniformGrid.Columns = 3;
            uniformGrid.Rows = 4;

            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Content = i;
                uniformGrid.Children.Add(button);
            }

            mainGrid.Children.Add(uniformGrid);
            this.Content = mainGrid;
        }
    }
}
