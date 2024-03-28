using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp36
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonModel Том;
        public MainWindow()
        {
            InitializeComponent();

            Том = new PersonModel();
            this.DataContext = Том;
        }
    }

    public class PersonModel : IDataErrorInfo
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Age":
                        if ((Age < 0) || (Age > 100))
                        {
                            error = "Вік повинен бути більше 0 і менше 100";
                        }
                        break;
                    case "Name":
                        //Обробка помилок для властивості Name
                        break;
                    case "Position":
                        //Обробка помилок для властивості Position
                        break;
                }
                return error;
            }

        }


    }
}
