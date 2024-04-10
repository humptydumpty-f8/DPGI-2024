using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _80_Привязка_в_коді
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ListBox listBox = new ListBox();
            MyData listData = new MyData();

            Binding binding = new Binding();
            binding.Source = listData;
            listBox.SetBinding(ListBox.ItemsSourceProperty, binding);

            this.Content = listBox;
        }
    }

    public class MyData : ObservableCollection<string>
    {
        public MyData()
        {
            Add("Item 1");
            Add("Item 2");
            Add("Item 3");
        }
    }
}
