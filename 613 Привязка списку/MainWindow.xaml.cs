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

namespace WpfApp21
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Створюється колекція обєктів
        List<Person> personList = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();

            personList.Add(new Person() { Name = "Bender", Age = 33 });
            personList.Add(new Person() { Name = "Kisa", Age = 55 });
            personList.Add(new Person() { Name = "Pupkin", Age = 20 });
            //Встановлюється контекст привязки
            this.DataContext = personList;
        }

        //Обробник події вибору елемента списку
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show((((Person)lbx.SelectedItem).Age).ToString());
        }
    }

    public class Person
    {

        private string nameValue;

        public string Name
        {
            get { return nameValue; }
            set { nameValue = value; }
        }

        private double ageValue;

        public double Age
        {
            get { return ageValue; }

            set
            {
                if (value != ageValue)
                {
                    ageValue = value;
                }
            }
        }
        //Перевантажений метод для виведення значень списку
        public override string ToString() { return this.Name; }

    }
}
