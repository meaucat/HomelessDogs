using HomelessDogs.Models;
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

namespace HomelessDogs.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        public static List<Employee> employees = new List<Employee>();
        public EmployeePage()
        {
            InitializeComponent();

            employees = App.db.Employee.Where(x => x.Id_post == 2).ToList();
            EmployeesLv.ItemsSource = employees;
        }

        private void EmployeesLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.selectedEmployee = EmployeesLv.SelectedItem as Employee;
            NavigationService.Navigate(new EditEmployeePage());
        }

        private void AddEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEmployeePage());
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainAdminPage());
        }
    }
}
