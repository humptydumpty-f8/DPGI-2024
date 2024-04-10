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

namespace _80_Заповнення_ItemsControl_за_допомогою_властивості_Items
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StackPanel stackPanel;
        public MainWindow()
        {
            InitializeComponent();

            // Add a panel that contains multpile objects to the ListBox.
            Ellipse ellipse = new Ellipse();
            TextBlock textBlock = new TextBlock();
            DateTime dateTime = DateTime.Now;

            ellipse.Width = 40;
            ellipse.Height = 40;
            ellipse.Fill = Brushes.Blue;

            textBlock.TextAlignment = TextAlignment.Center;
            textBlock.Text = dateTime.ToString();

            stackPanel = new StackPanel();
            stackPanel.Children.Add(ellipse);
            stackPanel.Children.Add(textBlock);
            
            listBox.Items.Add(stackPanel);
        }
    }
}
