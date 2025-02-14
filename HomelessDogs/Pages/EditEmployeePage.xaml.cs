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
    /// Логика взаимодействия для EditEmployeePage.xaml
    /// </summary>
    public partial class EditEmployeePage : Page
    {
        public EditEmployeePage()
        {
            InitializeComponent();
            Upload();
        }

        private void Upload()
        {
            SurnameTb.Text = App.selectedEmployee.Surname;
            NameTb.Text = App.selectedEmployee.Name;
            PatronymicTb.Text = App.selectedEmployee.Patronymic;
            LoginTb.Text = App.selectedEmployee.Login;
            PasswordTb.Text = App.selectedEmployee.Password;
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.Text, 0))
                {
                    e.Handled = true;
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка.");
            }
        }

        private void DeleteBTN_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите удалить сотрудника?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                App.db.Employee.Remove(App.selectedEmployee);
                App.db.SaveChanges();
                NavigationService.Navigate(new EmployeePage());
            }
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeePage());
        }

        private void EditEmployeeBTN_Click(object sender, RoutedEventArgs e)
        {
            var fieldsToCheck = new[] { SurnameTb.Text, NameTb.Text, PatronymicTb.Text, LoginTb.Text, PasswordTb.Text };
            if (fieldsToCheck.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Заполните все поля.");
            }
            else if (SurnameTb.Text == App.selectedEmployee.Surname && NameTb.Text == App.selectedEmployee.Name && PatronymicTb.Text == App.selectedEmployee.Patronymic && LoginTb.Text == App.selectedEmployee.Login && PasswordTb.Text == App.selectedEmployee.Password)
            {
                MessageBox.Show("Изменений не происходило.");
                return;
            }
            else
            {
                App.selectedEmployee.Surname = SurnameTb.Text;
                App.selectedEmployee.Name = NameTb.Text;
                App.selectedEmployee.Patronymic = PatronymicTb.Text;
                App.selectedEmployee.Login = LoginTb.Text;
                App.selectedEmployee.Password = PasswordTb.Text;
            }

            App.db.SaveChanges();

            MessageBox.Show("Данные изменены.");
            NavigationService.Navigate(new EmployeePage());
        }
    }
}
