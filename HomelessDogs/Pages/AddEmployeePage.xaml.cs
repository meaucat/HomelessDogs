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
    /// Логика взаимодействия для AddEmployeePage.xaml
    /// </summary>
    public partial class AddEmployeePage : Page
    {
        public AddEmployeePage()
        {
            InitializeComponent();

            PostCb.ItemsSource = App.db.Post.ToList();
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

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeePage());
        }

        private void AddEmployeeBTN_Click(object sender, RoutedEventArgs e)
        {
            var fieldsToCheck = new[] { SurnameTb.Text, NameTb.Text, PatronymicTb.Text, LoginTb.Text, PasswordTb.Text};
            if (fieldsToCheck.Any(string.IsNullOrWhiteSpace) || PostCb.SelectedItem == null)
            {
                MessageBox.Show("Заполните все поля.");
            }
            else
            {
                Employee employee = new Employee()
                {
                    Id_post = (PostCb.SelectedItem as Post).Id_post,
                    Surname = SurnameTb.Text,
                    Name = NameTb.Text,
                    Patronymic = PatronymicTb.Text,
                    Login = LoginTb.Text,
                    Password = PasswordTb.Text,
                };

                App.db.Employee.Add(employee);
                App.db.SaveChanges();

                MessageBox.Show("Сотрудник успешно добавлен.");
                NavigationService.Navigate(new EmployeePage());
            }
        }
    }
}
