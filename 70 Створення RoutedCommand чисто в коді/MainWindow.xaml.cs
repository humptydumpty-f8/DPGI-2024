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

namespace _70_Створення_RoutedCommand_чисто_в_коді
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

            //2-привязка і реєстрація команди
            CommandBinding customCommandBinding = new CommandBinding(CustomRoutedCommand, ExecutedCustomCommand, CanExecuteCustomCommand);            
            this.CommandBindings.Add(customCommandBinding);

            //3-створення кнопки з командою
            StackPanel CustomCommandStackPanel = new StackPanel();

            Button CustomCommandButton = new Button();
            CustomCommandButton.Content = "Custom Command Button";
            CustomCommandButton.Command = CustomRoutedCommand;
            
            CustomCommandStackPanel.Children.Add(CustomCommandButton);            
            this.Content = CustomCommandStackPanel;
        }
        // створення обробників подій
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
