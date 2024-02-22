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

namespace _4._10.GroupBox_in_code
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Define a GroupBox
            GroupBox groupBox = new GroupBox();
            groupBox.Header = "A GroupBox Test";
            groupBox.BorderThickness = new Thickness(1);
            groupBox.BorderBrush = Brushes.Green;
            groupBox.Margin= new Thickness(15);
                        

            // Add Layout control
            StackPanel stackPanel = new StackPanel();            
            
            RadioButton radioButton1 = new RadioButton();
            radioButton1.Content = "#1";
            radioButton1.IsChecked = true; 

            RadioButton radioButton2 = new RadioButton();
            radioButton2.Content = "#2";

            // Add child elements to the parent StackPanel
            stackPanel.Children.Add(radioButton1);
            stackPanel.Children.Add(radioButton2);

            groupBox.Content = stackPanel;
            this.Content = groupBox;
        }
    }
}
