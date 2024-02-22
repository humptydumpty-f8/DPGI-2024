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

namespace _4._9.ScrollViewer_in_code
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Define a ScrollViewer
            var myScrollViewer = new ScrollViewer();
            myScrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;

            // Add Layout control
            var myStackPanel = new StackPanel();
            myStackPanel.HorizontalAlignment = HorizontalAlignment.Left;
            myStackPanel.VerticalAlignment = VerticalAlignment.Top;

            TextBlock myTextBlock = new TextBlock();
            myTextBlock.TextWrapping = TextWrapping.Wrap;
            myTextBlock.Margin = new Thickness(0, 0, 0, 20);
            myTextBlock.Text = "Scrolling is enabled when it is necessary. Resize the Window, making it larger and smaller.";

            Rectangle myRectangle = new Rectangle();
            myRectangle.Fill = Brushes.Red;
            myRectangle.Width = 500;
            myRectangle.Height = 500;

            // Add child elements to the parent StackPanel
            myStackPanel.Children.Add(myTextBlock);
            myStackPanel.Children.Add(myRectangle);

            // Add the StackPanel as the lone child of the ScrollViewer
            myScrollViewer.Content = myStackPanel;

            // Add the ScrollViewer as the Content of the parent Window object
            this.Content = myScrollViewer;            
        }
    }
}
