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

namespace _3._9.Програмне_керування_Grid
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
            for (int j = 0; j < 10; j++)
            {
                MainGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(30) });
            }

            for (int j = 0; j < 10; j++)
            {
                MainGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(30) });
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {                 

                    Button b = new Button();
                    MainGrid.Children.Add(b);
                    Grid.SetRow(b, j);
                    Grid.SetColumn(b, i);

                    b.Click += new RoutedEventHandler(Button_Click);
                }
            }
        }
        
        //Забезпечує "попіксельне" малювання
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Background = (btn.Background != Brushes.Black)? Brushes.Black : (new Button()).Background;
        }
    }
}
