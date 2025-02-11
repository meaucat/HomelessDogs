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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public static List<Employee> employees = new List<Employee>();
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTB.Text.Trim();
            string password = PasswordPB.Password.Trim();

            employees = App.db.Employee.ToList();
            App.employee = employees.FirstOrDefault(x => x.Login == login && x.Password == password);

            if (App.employee != null && App.employee.Id_post == 1)
            {
                MessageBox.Show(App.employee.FullNameAuth);
                NavigationService.Navigate(new MainAdminPage());
            }
            else if (App.employee != null && App.employee.Id_post == 2)
            {
                MessageBox.Show(App.employee.FullNameAuth);
                NavigationService.Navigate(new VeterinarMainPage());
            }
            else
            {
                MessageBox.Show("Повторите попытку.");
                LoginTB.Text = string.Empty;
                PasswordPB.Password = string.Empty;
            }
        }

        private void GuestBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainGuestPage(new Employee()));
        }
    }
}
