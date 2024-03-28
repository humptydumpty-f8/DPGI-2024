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

namespace _70_Інтерфейс_ICommand
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //1-визначення команди
        public static RoutedCommand CustomRoutedCommand = new RoutedCommand();

        public MainWindow()
        {
            InitializeComponent();
        }
        
        //2-створення обробників подій
        private void ExecutedCustomCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Custom Command Executed");
        }

        private void CanExecuteCustomCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            Control target = e.Source as Control;

            if (target != null)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }
        
        
    }
}
