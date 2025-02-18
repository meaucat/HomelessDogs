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
    /// Логика взаимодействия для VisitsPage.xaml
    /// </summary>
    public partial class VisitsPage : Page
    {
        public VisitsPage()
        {
            InitializeComponent();
            CommentTb.Text = App.selectedSurvey.Comment;
            DateTimeTbB.Text = App.selectedSurvey.Date.ToString();
            StatusTB.Text = App.selectedSurvey.Status.Name;
            PacientTB.Text = App.selectedSurvey.Dog.SerialNumber;
            DiagnosisTB.Text = App.selectedSurvey.Illness.ToString();
            DoctorTB.Text = App.selectedSurvey.Employee.Name;
        }



        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VeterinarMainPage());
        }
    }
}
