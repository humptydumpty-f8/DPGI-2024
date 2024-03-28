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

namespace WpfApp30
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Оголошення колекції
        ObservableCollection<Person> itemsList;
        public MainWindow()
        {
            InitializeComponent();

            //Створення колекції
            itemsList = new ObservableCollection<Person>
            {
                new Person() {Name = "Vika", Age=20},
                new Person() {Name = "Roma", Age=30},
                new Person() {Name = "German", Age=25},
            };
            //Привязка колекції
            lstView.ItemsSource = itemsList;
        }

        private void lstView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Selected: " + (Person)lstView.SelectedItem);
        }
    }
    //Клас елементів списку
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return ($"name: {Name}  age: {Age}");
        }
    }
}
