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

namespace _2._3.Форма_з_кнопкою_без_XAML
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Нова форма
            this.Width = 600;
            this.Height = 350;
            this.Title = "Lection #2";

            // Крмпоновка
            Button btnClickMe = new Button();
            btnClickMe.Content = "Click me";
            btnClickMe.Height = 30;
            btnClickMe.Width = 75;
            btnClickMe.HorizontalAlignment = HorizontalAlignment.Left;
            btnClickMe.VerticalAlignment = VerticalAlignment.Top;

            Grid grid = new Grid();
            grid.Children.Add(btnClickMe);
            this.Content = grid;

            // Обробник
            btnClickMe.Click += btnClickMe_Click;
        }

        //Обробник події кліку по кнопці.
        //Виводить діалог з повідомленням про клік.
        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button was clicked");
        }
    }
}

