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

            PostCb.ItemsSource = App.db.Post.ToList();
        }

        private void Upload()
        {
            SurnameTb.Text = App.selectedEmployee.Surname;
            NameTb.Text = App.selectedEmployee.Name;
            PatronymicTb.Text = App.selectedEmployee.Patronymic;
            LoginTb.Text = App.selectedEmployee.Login;
            PasswordTb.Text = App.selectedEmployee.Password;
            PostCb.SelectedItem = App.selectedEmployee.Post;
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

        private void EditEmployeeBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
