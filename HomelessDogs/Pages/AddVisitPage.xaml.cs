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
    /// Логика взаимодействия для AddVisitPage.xaml
    /// </summary>
    public partial class AddVisitPage : Page
    {
        public AddVisitPage()
        {
            InitializeComponent();

            StatusCB.ItemsSource = App.db.Status.ToList();
            PacientCB.ItemsSource = App.db.Dog.ToList();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddInformationBTN_Click(object sender, RoutedEventArgs e)
        {
            if (DiagnosisTB.Text == string.Empty || CommentTb.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля.");
            }
            else
            {
                Survey survey = new Survey()
                {
                    Id_doctor = App.employee.Id_employee,
                    Id_dog = (PacientCB.SelectedItem as Dog).Id_dog,
                    Id_status = (StatusCB.SelectedItem as Status).Id_status,
                    Date = DateDP.SelectedDate,
                    Illness = DiagnosisTB.Text,
                    Comment = CommentTb.Text,
                };

                App.db.Survey.Add(survey);
                App.db.SaveChanges();

                MessageBox.Show("Прием проведен.");
                NavigationService.Navigate(new VeterinarMainPage());
            }
        }
    }
}
