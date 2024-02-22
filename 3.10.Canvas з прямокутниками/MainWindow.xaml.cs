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

namespace _3._11.Canvas_з_прямокутниками
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush customcolor;
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        //MouseEvent for canvas create and remove
        private void myCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource is Rectangle)
            {
                Rectangle activeRectangle = (Rectangle)e.OriginalSource;
                myCanvas.Children.Remove(activeRectangle); //remove canvas
            }
            else
            {
                // random color
                customcolor = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
                //canvas create
                Rectangle newRectangle = new Rectangle
                {
                    //properties set
                    Width = 50,
                    Height = 50,
                    Fill = customcolor,
                    StrokeThickness = 3,
                    Stroke = Brushes.Black
                };
                //position of mouse click area
                Canvas.SetLeft(newRectangle, Mouse.GetPosition(myCanvas).X);
                Canvas.SetTop(newRectangle, Mouse.GetPosition(myCanvas).Y);
                //canvas add
                myCanvas.Children.Add(newRectangle);
            }
        }
    }
}
