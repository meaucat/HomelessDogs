using HomelessDogs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
using System.Xml.Linq;

namespace HomelessDogs.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditVisitPage.xaml
    /// </summary>
    public partial class EditVisitPage : Page
    {
        public EditVisitPage()
        {
            InitializeComponent();
            StatusCB.ItemsSource = App.db.Status.Select(x => x.Name).ToList();
            CommentTb.Text = App.selectedSurvey.Comment;
            DateDP.SelectedDate = App.selectedSurvey.Date;
            StatusCB.SelectedIndex = App.selectedSurvey.Status.Id_status - 1;
            PacientTB.Text = App.selectedSurvey.Dog.SerialNumber;
            DiagnosisTB.Text = App.selectedSurvey.Illness;
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VisitsPage());
        }

        private void EditInformationBTN_Click(object sender, RoutedEventArgs e)
        {
            if (DiagnosisTB.Text == string.Empty || CommentTb.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля.");
            }
            else if (StatusCB.SelectedItem == App.selectedSurvey.Status && DateDP.SelectedDate == App.selectedSurvey.Date && DiagnosisTB.Text == App.selectedSurvey.Illness && CommentTb.Text == App.selectedSurvey.Comment)
            {
                MessageBox.Show("Изменений не происходило.");
                return;
            }
            else
            {
                App.selectedSurvey.Id_status = (StatusCB.SelectedItem as Status).Id_status;
                App.selectedSurvey.Date = DateDP.SelectedDate;
                App.selectedSurvey.Illness = DiagnosisTB.Text;
                App.selectedSurvey.Comment = CommentTb.Text;

                App.db.SaveChanges();

                MessageBox.Show("Данные изменены.");
                NavigationService.Navigate(new VeterinarMainPage());
            }
        }
    }
}
