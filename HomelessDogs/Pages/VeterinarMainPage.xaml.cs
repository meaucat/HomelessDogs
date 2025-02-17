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
using static System.Net.Mime.MediaTypeNames;

namespace HomelessDogs.Pages
{
    /// <summary>
    /// Логика взаимодействия для VeterinarMainPage.xaml
    /// </summary>
    public partial class VeterinarMainPage : Page
    {
        public VeterinarMainPage()
        {
            InitializeComponent();

            NameVeterinarsTB.Text = App.employee.VetText;
            DateTime now = DateTime.Today;

            PlannedVisitsLV.ItemsSource = App.db.Survey.Where(x => x.Date >= now && x.Id_doctor == App.employee.Id_employee).ToList();
            PreviousVisitsLV.ItemsSource = App.db.Survey.Where(x => x.Date < now && x.Id_doctor == App.employee.Id_employee).ToList();

            int count = App.db.Survey.Where(x => x.Date == now).ToList().Count;

            CountTb.Text = $"Приемов на сегодня: {count}. Хорошего Вам дня!";
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }

        private void PlannedVisitsLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.selectedSurvey = PlannedVisitsLV.SelectedItem as Survey;
            NavigationService.Navigate(new VisitsPage());
        }

        private void PreviousVisitsLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.selectedSurvey = PreviousVisitsLV.SelectedItem as Survey;
            NavigationService.Navigate(new VisitsPage());
        }
    }
}
