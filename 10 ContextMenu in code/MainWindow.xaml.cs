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

namespace _10_ContextMenu_in_code
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ContextMenu theMenu = new ContextMenu();
            MenuItem mia = new MenuItem();
            mia.Header = "Item1";
            MenuItem mib = new MenuItem();
            mib.Header = "Item2";
            MenuItem mic = new MenuItem();
            mic.Header = "Item3";
            theMenu.Items.Add(mia);
            theMenu.Items.Add(mib);
            theMenu.Items.Add(mic);
            this.ContextMenu = theMenu;
        }
    }
}
