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

namespace _4._11.TabItem_in_code
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Define a TabControl
            TabControl tabControl = new TabControl();

            // Add TabItem control
            TabItem tabItem1 = new TabItem();
            tabItem1.Header = "Tab1";

            TabItem tabItem2 = new TabItem();
            tabItem2.Header = "Tab2";
            tabItem2.IsSelected = true;

            // Add Layout control
            StackPanel stackPanel = new StackPanel();
            Button btn = new Button()
            {
                Content="Ok!",
                Width = 50
            };
            stackPanel.Children.Add(btn);

            tabItem2.Content = stackPanel;

            // Add TabItem elements to the  TabControl
            tabControl.Items.Add(tabItem1);
            tabControl.Items.Add(tabItem2);            

            this.Content = tabControl;
        }
    }
}
