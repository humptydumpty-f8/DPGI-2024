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

namespace WpfApp29
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
                new Person() {name = "Vika", age=20},
                new Person() {name = "Roma", age=30},
                new Person() {name = "German", age=25},
            };
            //Привязка колекції
            lstBox.ItemsSource = itemsList;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            itemsList.Add(new Person() { name = txtName.Text, age = int.Parse(txtAge.Text) });
        }
    }

    //Клас елементів списку
    class Person
    {
        public string name = "Undefined";
        public int age;

        public override string ToString()
        {
            return ($"name: {name}  age: {age}");
        }
    }
}
