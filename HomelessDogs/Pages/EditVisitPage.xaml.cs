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
            DiagnosisTB.Text = App.selectedSurvey.Illness.ToString();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VisitsPage());
        }

        private void EditInformationBTN_Click(object sender, RoutedEventArgs e)
        {
            //доделать
            StatusCB.ItemsSource = App.db.Status.Select(x => x.Name).ToList();
            CommentTb.Text = App.selectedSurvey.Comment;
            DateDP.SelectedDate = App.selectedSurvey.Date;
            StatusCB.SelectedIndex = App.selectedSurvey.Status.Id_status - 1;
            PacientTB.Text = App.selectedSurvey.Dog.SerialNumber;
            DiagnosisTB.Text = App.selectedSurvey.Illness.ToString();
        }
    }
}
