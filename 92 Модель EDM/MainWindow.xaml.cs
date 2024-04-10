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

namespace WpfApp39
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DatabaseSQLEntities context;

        List<EMPLOYEE> empList;
        List<DEPARTMENT> depList;
        ObservableCollection<EMPLOYEE> selectedEmployeesList;

        public MainWindow()
        {
            InitializeComponent();

            context = new DatabaseSQLEntities();

            empList = new List<EMPLOYEE>();
            depList = new List<DEPARTMENT>();

            selectedEmployeesList = new ObservableCollection<EMPLOYEE>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (EMPLOYEE var in context.EMPLOYEE)
            {
                empList.Add(var);
            }
            employeeGrid.ItemsSource = empList;

            foreach (DEPARTMENT var in context.DEPARTMENT)
            {
                depList.Add(var);
            }
            departmentGrid.ItemsSource = depList;

            cmbDepartment.ItemsSource = depList;
        }

        private void cmbDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedEmployeesList.Clear();//Обовязково!!!
            var selectedEmployees = context.EMPLOYEE.Where(C => C.DEPT_ID == ((DEPARTMENT)cmbDepartment.SelectedItem).DEPT_ID).ToList<EMPLOYEE>();
            foreach (EMPLOYEE var in selectedEmployees)
            {
                selectedEmployeesList.Add(var);
            }
            selectedEmployeesGrid.ItemsSource = selectedEmployeesList;

        }
    }
}
