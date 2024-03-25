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

namespace _70_Імплементація_ICommand
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        //1-визначення команди
        public static TestCommand CustomTestCommand = new TestCommand();

        public MainWindow()
        {
            InitializeComponent();

            //3-привязка і реєстрація команди
            CommandBinding customCommandBinding = new CommandBinding(CustomTestCommand);
            this.CommandBindings.Add(customCommandBinding);

            //4-створення кнопки з командою
            StackPanel CustomCommandStackPanel = new StackPanel();

            Button CustomCommandButton = new Button();
            CustomCommandButton.Content = "Custom Command Button";
            CustomCommandButton.Command = CustomTestCommand;

            CustomCommandStackPanel.Children.Add(CustomCommandButton);
            this.Content = CustomCommandStackPanel;
        }
        
        
    }
}
